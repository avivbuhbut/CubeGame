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


        if (CubeTrans.position.x == 33f)
            Debug.Log("Got To POS!");


        if (counter == 3)
            animAtor.SetBool("AcitveFloorDrop", true);

    
        

    }


     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "LowerLevelCube")
            Debug.Log(collision.gameObject.tag);
    }
}
