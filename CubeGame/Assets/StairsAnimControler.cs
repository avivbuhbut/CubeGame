using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsAnimControler : MonoBehaviour
{

    public Animator animAtorCube1;
    public Animator animAtorCube2;
    public Animator animAtorCube3;
    public Animator animAtorCube4;
    public Animator animAtorCube5;
    public Animator animAtorCube6;
    public Animator animAtorCube7;

    // Start is called before the first frame update
    void Start()
    {
        animAtorCube1.SetBool("ActiveCube1", false);
        animAtorCube2.SetBool("ActiveCube2", false);
        animAtorCube3.SetBool("ActiveCube3", false);
        animAtorCube4.SetBool("ActiveCube4", false);
        animAtorCube5.SetBool("ActiveCube5", false);
        animAtorCube6.SetBool("ActiveCube6", false);
        animAtorCube7.SetBool("ActiveCube7", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animAtorCube1.SetBool("ActiveCube1", true);
            animAtorCube2.SetBool("ActiveCube2", true);
            animAtorCube3.SetBool("ActiveCube3", true);
            animAtorCube4.SetBool("ActiveCube4", true);
            animAtorCube5.SetBool("ActiveCube5", true);
            animAtorCube6.SetBool("ActiveCube6", true);
            animAtorCube7.SetBool("ActiveCube7", true);
        }
    }
}
