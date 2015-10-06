using UnityEngine;
using System.Collections;


public enum EntityType
{
    Player = 1,
    Platform = 2,
    Ennemi = 4,
}

[System.Serializable]
public struct EntityState
{
    [SerializeField]
    public EntityType type; 
    public bool isAlive;
    public float speed;
    [SerializeField]
    public float sphereCollider;
    public Vector2 direction;
    [SerializeField]
    public Vector2 position;
}

[ExecuteInEditMode]
class Entity : MonoBehaviour
{
    [SerializeField]
    EntityState state;

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
        transform.position = state.position;
    }

    void OnGizmos()
    {

    }
}