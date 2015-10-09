using UnityEngine;
using System.Collections;
using System;

public class Ennemy : Entity
{
    #region Unity Methods

    void Update()
    {
        //computing left/right ctrl
        if (Control.Left == Control)
        {
            moveVector[0] = -speed*Time.deltaTime;
        }
        else if (Control.Right == Control)
        {
            moveVector[0] = speed*Time.deltaTime;
        }
        else
        {
            moveVector[0] = 0f;
        }

        //computing fall/jump ctrl
        if (useGravity)
        {
            moveVector[1] = moveVector[1] + Physics.gravity[1]*Time.deltaTime;
        }

    }

    #endregion

    #region Entity
    [SerializeField]
    bool canMove = false;
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    bool useGravity = true;
    [SerializeField]
    bool isAlive = true;
    EntityAction _state;

    //This is just initialisation. i can write raw things.
    public override EntityState Me_Start()
    {
        return new EntityState
        {
            type = EntityType.Ennemy,
            canMove = canMove,
            position = transform.position,
            useGravity = useGravity,
            isAlive = isAlive,
            initial = _state = new EntityAction
            {
                speed = Vector2.zero,
                control = Control.Stop
            }
        };
    }

    //This is an update method. 
    public override EntityAction Me_Action()
    {
        _state.speed = moveVector;
        _state.control = control;
        return _state;
    }

    public override void Me_Update(EntityState state)
    {
        transform.position = state.position;
    }

    #endregion
}
