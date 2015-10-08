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

public struct EntityState
{
    #region Const Values
    /// <summary>
    /// EntityState only
    /// </summary>
    public EntityType type;
    /// <summary>
    /// EntityState only
    /// </summary>
    public bool canMove;
    /// <summary>
    /// EntityState only
    /// </summary>
    public Vector2 position;
    /// <summary>
    /// EntityState only
    /// </summary>
    public bool useGravity;
    /// <summary>
    /// EntityState only
    /// </summary>
    public bool isAlive;
    #endregion
    public EntityAction initial;
}

public struct EntityAction
{
    public Vector2 speed;
    public Control control;

    public static EntityAction Default
    {
        get
        {
            return new EntityAction
            {
                speed = Vector2.zero,
                control = Control.Stop
            };
        }
    }
}
