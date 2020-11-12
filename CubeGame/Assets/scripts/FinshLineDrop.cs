using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinshLineDrop : ColidedScript
{

    private Animation anim;
    [SerializeField] Animator animAtor;


    public Transform CubeTrans;





    // Start is called before the first frame update
    void Start()
    {
      
   


        animAtor.SetBool("AcitveFloorDrop", false);





    }


    // Update is called once per frame
    void Update()
    {





        if (counter == 3)
        {
         
            animAtor.SetBool("AcitveFloorDrop", true);
        }



    
        

    }


     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "LowerLevelCube")
            Debug.Log(collision.gameObject.tag);
    }

     void OnCollisionExit(Collision collision)
    {
        counter++;

        if (collision.gameObject.tag == "PizzaBox" && counter == 3)
            Debug.Log("All of the pizza boxes are out!");
    }
}
