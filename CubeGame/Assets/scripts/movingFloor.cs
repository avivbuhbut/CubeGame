using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFloor : ColidedScript
{
   
    private Animation anim;
    [SerializeField] Animator animAtor ;


    // Start is called before the first frame update
    void Start()
    {



        animAtor.SetBool("Activate", false) ;






       // GameObject FinishPlate = GameObject.Find("FinishPlate");

     //   Counter = FinishPlate.GetComponent<ColidedScript>().getCounter();
     
        

    }
   

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Moving floor " + counter);
        // Debug.Log("moving floor counter: " + colidedScript.counter);
        //animAtor.SetBool("Activate", true);
              if (counter == 3)
                animAtor.SetBool("Activate", true);

        ///    Debug.Log("inside moving floor");



    }
}
