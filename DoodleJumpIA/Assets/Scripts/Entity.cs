using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
[SelectionBase]
[DisallowMultipleComponent]
class Entity : MonoBehaviour
{
    [SerializeField]
    EntityType type = EntityType.Player;
    [SerializeField]
    bool isAlive = true;
    bool isGrounded = false;
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    float sphereCollider = 1f;
    Vector2 direction;

    void Awake()
    {

    }

    void Update()
    {

    }

    void OnDrawGizmosSelected()
    {
        //Gizmos.color = Color.green;
        //Gizmos.DrawWireSphere(transform.position, state.sphereCollider);
    }

    #region state managing

    EntityState _state;

    public EntityState State
    {
        get
        {
            _state.type = type;
            _state.isAlive = isAlive;
            _state.isGrounded = isGrounded;
            _state.speed = speed;
            _state.sphereCollider = sphereCollider;
            _state.direction = direction;
            _state.position = transform.position;
            return _state;
        }
    }

    #endregion
}