using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Worldstate = System.Collections.Generic.Dictionary<Entity, EntityState>;

[DisallowMultipleComponent]
public class Engine : MonoBehaviour
{
    Worldstate actualWorldState = new Worldstate(1000);

    void Awake()
    {

    }
	
	void Update()
    {
        
    }

    void FixedUpdate()
    {
        UpdateActualWorldState();
    }

    public void AddEntity(Entity entity)
    {
        actualWorldState.Add(entity, entity.State);
    }

    public void RemoveEntity(Entity entity)
    {
        actualWorldState.Remove(entity);
    }

    /// <summary>
    /// This method make the world take the state given in parameter
    /// </summary>
    /// <param name="state">World state to apply</param>
    void UpdateActualWorldState()
    {
        var iter = actualWorldState.GetEnumerator();
        while(iter.MoveNext())
        {
            actualWorldState[iter.Current.Key] = iter.Current.Key.State;
        }
    }

    /// <summary>
    /// This methode compute next possible worldStates and return this in the form of a tree.
    /// </summary>
    /// <param name="nbFrames">number of frames(time) to precompute</param>
    /// <returns></returns>
    Worldstate[] ComputeNextStates(int nbFrames)
    {
        //Worldstate[] nextStates = new Worldstate[];


        return new Worldstate[0];
    }
}
