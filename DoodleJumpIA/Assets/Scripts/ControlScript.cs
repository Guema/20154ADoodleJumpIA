using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

    [SerializeField]
    Entity type;

    Control control;
    private Rigidbody _rigidbody;


    void Start () {

    }

 
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //destruction du personnage au contact des ennemis
        if (collision.gameObject.name == "Ennemy1" | collision.gameObject.name == "Ennemy2" | collision.gameObject.name == "Ennemy3")
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        //Declaration des inputs valables
        transform.Translate((Vector2.up * 2) * 4f * Time.deltaTime);
        bool WantMoveToRight = Input.GetKey(KeyCode.RightArrow);
        bool WantMoveToLeft = Input.GetKey(KeyCode.LeftArrow);
        bool WantMoveToTop = Input.GetKey(KeyCode.UpArrow);
        bool WantMoveToBot = Input.GetKey(KeyCode.DownArrow);

        bool WantToCast = Input.GetKeyDown(KeyCode.Mouse0);

        bool SwitchBlock_One = Input.GetKeyDown(KeyCode.A);
        bool SwitchBlock_Two = Input.GetKeyDown(KeyCode.Z);
        bool SwitchBlock_Three = Input.GetKeyDown(KeyCode.E);
        bool SwitchBlock_Four = Input.GetKeyDown(KeyCode.R);

        Vector3 direction = Vector3.zero;
        //appel de la méthode en fonction du controle demandé
        if (WantMoveToRight)
        {
            //transform.Translate(new Vector3(1, 0, 0)/7); 
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
        }
        if (WantMoveToLeft)
        {
            //transform.Translate(new Vector3(-1, 0, 0)/7);
            transform.Translate(Vector2.left * 4f * Time.deltaTime);
        }
     /*   if (WantMoveToTop)
        {
            //transform.Translate(new Vector3(0, 1, 0)/7);
            transform.Translate((Vector2.up*2) * 4f * Time.deltaTime);
        }*/
        if (WantMoveToBot)
        {
            transform.Translate(new Vector3(0, -1, 0)/7);
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
