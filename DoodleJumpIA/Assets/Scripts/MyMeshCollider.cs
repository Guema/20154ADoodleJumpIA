using UnityEngine;
using System.Collections;

public class MyMeshCollider : MonoBehaviour
{
    [SerializeField]
    Vector2 position = Vector2.zero;
    [SerializeField]
    ColliderType type = ColliderType.Rect;
    
	void Update ()
    {
	
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(position, 1f);
    }
}
