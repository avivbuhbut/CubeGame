using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFloor : Colided
{

    private Animation anim;
    [SerializeField] Animator animAtor ;
    // Start is called before the first frame update
    void Start()
    {
        //  anim = GameObject.Find("MovingDownCube").GetComponent<Animation>();
        //  anim.enabled = true;
        //anim = gameObject.GetComponent<Animation>();
        //m.enabled = false;

     
      
        animAtor.SetBool("Activate", false);
    }
   

    // Update is called once per frame
    void Update()
    {


        if (counter == 3)
            animAtor.SetBool("Activate", true);

    }
}
