using UnityEngine;
using System.Collections;


public enum EntityType
{
    Player = 1,
    Platform = 2,
    Ennemy = 4,
}

[System.Serializable]
public struct EntityState
{
    [SerializeField]
    public EntityType type;
    [SerializeField]
    public bool isAlive;
    [System.NonSerialized]
    public bool isGrounded;
    [SerializeField]
    public float speed;
    [SerializeField]
    public float sphereCollider;
    [System.NonSerialized]
    public Vector2 direction;
    [SerializeField]
    public Vector2 position;
}

[ExecuteInEditMode]
class Entity : MonoBehaviour
{
    [SerializeField]
    EntityState state = new EntityState()
    {
        type = EntityType.Player,
        isAlive = true,
        isGrounded = false,
        speed = 1f,
        sphereCollider = 1f,
        direction = Vector2.zero,
        position = Vector2.zero
    };

    public EntityState State
    {
        get
        {
            return state;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        if (!Application.isPlaying)
            state.position = transform.position;
        transform.position = state.position;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, state.sphereCollider);
    }
}