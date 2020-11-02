using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideMeshText : MonoBehaviour
{



    /*
     
     
     Creating a meshTextPro Follwing gameobject:

    1.set up a canvas 
    2.in the canvas setting - give the canvans the wanted camera , set the Ui Scale Mode to 
    "Scale with Screen Size" and in the refrence resoultion put your screen resolition.
    3.create a textMes (Create -> create3d -> TextMeshPro) and place it inisde the canvas (as a child)
    4.go to scene and place the text "phisicly" where you want it to be when the game is played 
    (in the area where the camera can see it ofcourse).
    5. control the textmeshpro with a scrip.

    example:

     public TextMeshPro pizzaBoxTextMesh;


     void Start()
    {
    
       pizzaBoxTextMesh.gameObject.SetActive(true);
     
     }

    void update()
    {

       if ((vel.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {

         
            pizzaBoxTextMesh.gameObject.SetActive(true);
            
           pizzaBoxTextMesh.text = "Total Score: " + localScore;

    }
     

    6.DONE!
     
     
     
     
     
     
     
     
     
     
     
     
     */
}
