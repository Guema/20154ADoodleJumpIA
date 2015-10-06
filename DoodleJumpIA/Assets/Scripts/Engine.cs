using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Worldstate = System.Collections.Generic.Dictionary<Entity, EntityState>;

[DisallowMultipleComponent]
public class Engine : MonoBehaviour
{

    static Engine engine;
    Worldstate actualWorldState = new Worldstate(10000);

    void Awake ()
    {
        engine = this;
	}
	
	void Update ()
    {
	       
	}

    void FixedUpdate()
    {

    }

    public static void AddEntity(Entity entity)
    {
        engine.actualWorldState.Add(entity, entity.State);
    }

    public static void RemoveEntity(Entity entity)
    {
        engine.actualWorldState.Remove(entity);
    }

    /// <summary>
    /// This method make the world take the state given in parameter
    /// </summary>
    /// <param name="state">World state to apply</param>
    void UpdateActualWorldState()
    {
        var i = actualWorldState.GetEnumerator();
    }

    /// <summary>
    /// This methode compute next possible worldStates and return this in the form of a tree.
    /// </summary>
    /// <param name="nbFrames">number of frames(time) to precompute</param>
    /// <returns></returns>
    Worldstate[] ComputeGameStates(int nbFrames)
    {
        return new Worldstate[0];
    }
}
