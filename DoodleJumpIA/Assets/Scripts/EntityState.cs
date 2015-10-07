using UnityEngine;
using System.Collections;

public enum ColliderType
{
    Square,
    Circle
}

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

public struct EntityState
{
    public EntityType type;
    public bool isAlive;
    public bool isGrounded;
    public float speed;
    public float sphereCollider;
    public Vector2 direction;
    public Vector2 position;
}
