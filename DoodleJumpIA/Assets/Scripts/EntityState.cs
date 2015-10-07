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
    Doodle = 1,
    Platform = 2,
    Ennemy = 4,
}

//Temporaire
public struct EntityState
{
    #region Const Values
    /// <summary>
    /// MyEngine_Init only
    /// </summary>
    public EntityType type;
    /// <summary>
    /// MyEngine_Init only
    /// </summary>
    public bool canMove;
    /// <summary>
    /// MyEngine_Init only
    /// </summary>
    public Vector2 position;
    #endregion
    #region Changing Values
    public bool isAlive;
    public bool useGravity;
    public Vector2 speed;
    public Control control;
    #endregion
}
