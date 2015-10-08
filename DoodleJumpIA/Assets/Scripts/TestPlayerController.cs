using UnityEngine;
using System.Collections;

public class TestPlayerController : Controller
{
    #region Unity Methods

    override protected void Reset()
    {
        base.Reset();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            entity.Control = Control.Left;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            entity.Control = Control.Right;
        }
        else
        {
            entity.Control = Control.Stop;
        }
    }

    #endregion


}
