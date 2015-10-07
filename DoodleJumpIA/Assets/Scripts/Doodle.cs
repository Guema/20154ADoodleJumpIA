using UnityEngine;
using System.Collections;
using System;

public class Doodle : Entity
{
    #region Unity Methods
    void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}
    #endregion

    #region Entity

    [SerializeField]
    float speed = 1f;
    [SerializeField]
    bool useGravity = true;
    Vector2 MoveVector;
    [SerializeField]
    bool isAlive = true;
    EntityState _state;

    //This is an update method. 
    public override EntityState MyEngine_GetWill()
    {
        _state.speed = MoveVector;
        return _state;
    }

    //This is just initialisation. i can write raw things.
    public override EntityState MyEngine_Init()
    {
        _state = new EntityState
        {
            type = EntityType.Doodle,
            isAlive = isAlive,
            canMove = true,
            speed = Vector2.zero,
            position = transform.position,
            control = Control.Stop
        };
        return _state; 
    }

    public override void MyEngine_SetState(EntityState state)
    {
        transform.position = state.position;
    }

    #endregion
}
