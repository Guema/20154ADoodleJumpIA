using UnityEngine;
using System.Collections;

public enum ColliderType
{
    Square = 1,
    Circle = 2
}

public enum Control
{
    Stop = 1,
    Right = 2,
    Left = 4
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
    public bool canMove;
    public float speed;
    public float sphereCollider;
    public Vector2 direction;
    public Vector2 position;
    public Control control;
}
