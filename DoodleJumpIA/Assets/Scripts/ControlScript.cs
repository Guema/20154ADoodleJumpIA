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
    void Update() {
    }

    void FixedUpdate() { 
        //Declaration des inputs valables
        bool WantMoveToRight = Input.GetKeyDown(KeyCode.RightArrow);
        bool WantMoveToLeft = Input.GetKeyDown(KeyCode.LeftArrow);

        bool WantToCast = Input.GetKeyDown(KeyCode.Mouse0);

        bool SwitchBlock_One = Input.GetKeyDown(KeyCode.A);
        bool SwitchBlock_Two = Input.GetKeyDown(KeyCode.Z);
        bool SwitchBlock_Three = Input.GetKeyDown(KeyCode.E);
        bool SwitchBlock_Four = Input.GetKeyDown(KeyCode.R);

        //appel de la méthode en fonction du controle demandé
        if (WantMoveToRight)
        {
            Debug.Log("droite !");           
        }
        if (WantMoveToLeft)
        {
            Debug.Log("gauche !");
        }

        if (WantToCast)
        {
            Debug.Log("cast !");
        }

        if (SwitchBlock_One)
        {
            Debug.Log("Block 1 !");
        }
        if (SwitchBlock_Two)
        {
            Debug.Log("Block 2  !");
        }
        if (SwitchBlock_Three)
        {
            Debug.Log("Block 3 !");
        }
        if (SwitchBlock_Four)
        {
            Debug.Log("Block 4 !");
        }











        /* if (control.Left && !control.Right)
         {
             type.Direction[0}.x = type.Direction.x - type.Speed;
         }
         else if (control.Right && !control.Left)
         {

         }
         else
         {

         }*/
    }
}
