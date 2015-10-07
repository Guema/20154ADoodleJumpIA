using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WorldState = System.Collections.Generic.Dictionary<Entity, EntityState>;

public class MyGameEngine : MonoBehaviour
{

    #region Unity Methods
    void Awake ()
    {
        SerializeScene();
    }

    void Start ()
    {
	    
	}

    void Update ()
    {
	
	}

    void FixedUpdate ()
    {

    }
    #endregion

    #region Game Engine

    WorldState worldState;

    /// <summary>
    /// This method once to serialize all GameEntities to make the engine able to use them.
    /// </summary>
    void SerializeScene()
    {
        var pull = GetComponentsInChildren<Entity>();
        for(int i = 0; i<pull.Length; i++)
        {

        }
    }

    /// <summary>
    /// This method add the entity in parameter to MyGameObject dictionary and initialise it.
    /// </summary>
    /// <param name="entity"></param>
    public void AddEntity(Entity entity)
    {
        if(!worldState.ContainsKey(entity))
            worldState.Add(entity, entity.MyEngine_Init());
    } 

    /// <summary>
    /// This method remove the entity in parameter from MyGameObjet dictionary.
    /// </summary>
    /// <param name="entity"></param>
    public void RemoveEntity(Entity entity)
    {
        if(worldState.ContainsKey(entity))
            worldState.Remove(entity);
    }

    #endregion
}
