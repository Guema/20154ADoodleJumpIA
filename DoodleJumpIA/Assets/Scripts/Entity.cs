using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
[SelectionBase]
[DisallowMultipleComponent]
public class Entity : MonoBehaviour
{
    [SerializeField]
    EntityType type = EntityType.Player;
    [SerializeField]
    bool isAlive = true;
    [SerializeField]
    bool canMove = false;
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    ColliderType coltype = ColliderType.Square;
    [SerializeField]
    float sphereCollider = 1f;
    [SerializeField]
    bool useGravity = false;
    Vector2 direction;
    Control control = Control.Stop;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        if(coltype == ColliderType.Circle)
        {
            Gizmos.DrawWireSphere(transform.position, sphereCollider);
        }
    }

    #region state managing

    EntityState _state;

    public EntityState State
    {
        get
        {
            _state.type = type;
            _state.isAlive = isAlive;
            _state.canMove = canMove;
            _state.speed = speed;
            _state.sphereCollider = sphereCollider;
            _state.direction = direction;
            _state.position = transform.position;
            _state.control = control;
            return _state;
        }
    }

    public void Engine_SetState(EntityState state)
    {

    }

    #endregion

    #region GET/SET

    public Control Control
    {
        get
        {
            return control;
        }

        set
        {
            control = value;
        }
    }
    #endregion
}
