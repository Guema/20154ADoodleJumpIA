using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Entity))]
public class ControlScript : MonoBehaviour {

    [SerializeField]
    Entity entity;

    void Reset()
    {
        entity = GetComponent<Entity>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            entity.Control = Control.Left;
        else if (!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
            entity.Control = Control.Right;
        else
            entity.Control = Control.Stop;
    }
}
