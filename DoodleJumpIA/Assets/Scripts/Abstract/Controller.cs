using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(Entity))]
public abstract class Controller : MonoBehaviour
{

    #region Unity Methods

    // This method is called on component added/reseted
    protected virtual void Reset()
    {
        entity = GetComponent<Entity>();
    }

    #endregion

    #region Controller

    [SerializeField]
    protected Entity entity;

    #endregion
}
