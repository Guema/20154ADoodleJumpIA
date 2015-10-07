using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Worldstate = System.Collections.Generic.Dictionary<Entity, EntityState>;

[DisallowMultipleComponent]
public class Engine : MonoBehaviour
{
    Worldstate actualWorldState = new Worldstate(1000);
    [SerializeField]
    int prout = 0;

    void Awake()
    {
        AddEntity(GetComponentsInChildren<Entity>());
    }
	
	void Update()
    {

    }

    void FixedUpdate()
    {
        UpdateActualWorldState();
    }

    /// <summary>
    /// Add entity(ies) in dictionary.
    /// </summary>
    /// <param name="entity">Entity(ies) to add.</param>
    public void AddEntity(Entity entity)
    {
        actualWorldState.Add(entity, entity.State);
    }

    public void AddEntity(Entity[] entity)
    {
        for(int i = 0; i<entity.Length; i++)
        {
            prout++;
            actualWorldState.Add(entity[i], entity[i].State);
        }
    }


    /// <summary>
    /// Remove Entity(ies) from dictionary.
    /// </summary>
    /// <param name="entity">Entity(ies) to remove.</param>
    public void RemoveEntity(Entity entity)
    {
        actualWorldState.Remove(entity);
    }

    public void RemoveEntity(Entity[] entity)
    {
        for (int i = 0; i < entity.Length; i++)
        {
            actualWorldState.Remove(entity[i]);
        }
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
        return new Worldstate[nbFrames];
    }
}
