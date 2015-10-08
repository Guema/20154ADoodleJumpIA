using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WorldState = System.Collections.Generic.Dictionary<Entity, EntityState>;
using ActionState = System.Collections.Generic.Dictionary<Entity, EntityAction>;

public class MyGameEngine : MonoBehaviour
{

    #region Unity Methods

    void Start ()
    {
        StartScene();
    }

    void Update ()
    {
	    
	}

    void FixedUpdate ()
    {
        Action();
        UpdateScene();
    }
    #endregion

    #region Game Engine

    WorldState worldState = new WorldState(1000);
    ActionState actionState = new ActionState();

    /// <summary>
    /// This method once to serialize all GameEntities to make the engine able to use them.
    /// </summary>
    void StartScene()
    {
        var pull = GetComponentsInChildren<Entity>();
        for(int i = 0; i<pull.Length; i++)
        {
            worldState.Add(pull[i], pull[i].Me_Start());
        }
    }

    /// <summary>
    /// This method is called to get all action desired by entities.
    /// </summary>
    void Action()
    {
        foreach(var p in worldState)
        {
            if(worldState[p.Key].canMove)
            {
                actionState[p.Key] = p.Key.Me_Action();
            }
        }
        //Call Event to say end of gathering action
    }

    /// <summary>
    /// This method is called to refresh scene.
    /// </summary>
    void UpdateScene()
    {
        foreach(var p in actionState)
        {
            EntityState newstate = worldState[p.Key];
            newstate.position += actionState[p.Key].speed;
            worldState[p.Key] = newstate;
        }
        foreach(var p in worldState)
        {
            p.Key.Me_Update(p.Value);
        }
    }

    /// <summary>
    /// This method add the entity in parameter to MyGameObject dictionary and initialise it.
    /// </summary>
    /// <param name="entity"></param>
    public void AddEntity(Entity entity)
    {
        if(!worldState.ContainsKey(entity))
            worldState.Add(entity, entity.Me_Start());
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
