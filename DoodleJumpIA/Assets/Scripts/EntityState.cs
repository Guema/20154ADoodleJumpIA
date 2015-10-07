using UnityEngine;
using System.Collections;

public enum Control
{
    Left = 1,
    Right = 2,
}

public enum EntityType
{
    Player = 1,
    Platform = 2,
    Ennemy = 4,
}

public enum ColliderType {
    isSphereCollider = 1,
    isSegmentCollider = 2,
};

public struct EntityState
{
    public EntityType type;
    public ColliderType colliderType;
    public bool isAlive;
    public bool isGrounded;
    public float speed;
    public float sphereCollider;
    public Vector2 direction;
    public Vector2 position;
    public Vector3 segmentCollider;
}
