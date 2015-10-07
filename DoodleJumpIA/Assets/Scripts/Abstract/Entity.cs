using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[SelectionBase]
public abstract class Entity : MonoBehaviour 
{

    /// <summary>
    /// This method will be called when MyGameEngine has to set a new state for this Entity
    /// </summary>
    /// <param name="state"></param>
    public abstract void MyEngine_SetState(EntityState state);
    /// <summary>
    /// This method will be called once, and is here to init MyGameEngine with initial state
    /// </summary>
    /// <returns></returns>
    public abstract EntityState MyEngine_Init();
    /// <summary>
    /// This method will be called on each FixedUpdate and is here to update parameters Entity can change during runtime.
    /// </summary>
    /// <returns></returns>
    public abstract EntityState MyEngine_GetWill();
}
