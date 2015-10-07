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
    ColliderType colliderType = ColliderType.isSphereCollider;
    [SerializeField]
    bool isAlive = true;
    bool isGrounded = false;
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    float sphereCollider = 1f;
    [SerializeField]
    Vector3 segmentCollider = new Vector3(1f, 1f, 0);
    Vector2 direction;

    void OnEnable()
    {
        Engine.AddEntity(this);
    }

    void OnDisable()
    {
        Engine.RemoveEntity(this);
    }

    void Update()
    {

    }

    void OnDrawGizmosSelected()
    {
        //Gizmos.color = Color.green;
       /* if(_state.colliderType == ColliderType.isSphereCollider)
            Gizmos.DrawWireSphere(transform.position, _state.sphereCollider);
        else
            Gizmos.DrawWireCube(transform.position, _state.segmentCollider);*/
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

    public void SetState(EntityState state)
    {

    }

    #endregion

    #region interactions

    #endregion
}