using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class GetId : MonoBehaviour {

	void Update ()
    {
        Debug.Log(gameObject.GetInstanceID());
	}
}
