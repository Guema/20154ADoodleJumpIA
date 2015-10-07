using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

    [SerializeField]
    Entity type;

    Control control;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (control.Left && !control.Right)
        {
            type.Direction[0}.x = type.Direction.x - type.Speed;
        }
        else if (control.Right && !control.Left)
        {

        }
        else
        {

        }
    }
}
