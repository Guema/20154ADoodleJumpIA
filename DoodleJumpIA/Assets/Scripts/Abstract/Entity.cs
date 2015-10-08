using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[SelectionBase]
public abstract class Entity : MonoBehaviour 
{
    #region Base Members
    protected Vector2 moveVector = Vector2.zero;

    public Vector2 MoveVector
    {
        get
        {
            return moveVector;
        }

        set
        {
            moveVector = value;
        }
    }

    #endregion

    #region Interface
    /// <summary>
    /// This method will be called once, and is here to init MyGameEngine with initial state
    /// </summary>
    /// <returns></returns>
    public abstract EntityState Me_Start();
    /// <summary>
    /// This method will be called on each FixedUpdate, and represent Entity desisions
    /// </summary>
    /// <returns>Initial State</returns>
    public abstract EntityAction Me_Action();
    /// <summary>
    /// This method will be called on each FixedUpdate to actualise Entity
    /// </summary>
    /// <param name="state"></param>
    public abstract void Me_Update(EntityState state);
    #endregion
}
