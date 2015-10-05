using UnityEngine;
using System.Collections;

struct EntityState
{
    bool isAlive;
    float speed;
    Vector2 direction;
    Vector2 position;

}

public class Entity : MonoBehaviour
{
    bool isAlive;
    Vector2 speed;
}
