using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{


        // You must set the cursor in the inspector.
        public Texture2D crosshair;

        void Start()
        {


        ActiveCrossHair();
        }


     void Update()
    {

        if (Input.GetKey(KeyCode.Q))
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }


    public void ActiveCrossHair()
    {
        //  crosshair = null;


        //set the cursor origin to its centre. (default is upper left corner)
        Vector2 cursorOffset = new Vector2(crosshair.width / 2, crosshair.height / 2);

        //Sets the cursor to the Crosshair sprite with given offset 
        //and automatic switching to hardware default if necessary
        Cursor.SetCursor(crosshair, cursorOffset, CursorMode.Auto);
    }
}

