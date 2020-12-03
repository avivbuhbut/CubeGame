using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderForPizzaAndPlayer : MonoBehaviour
{
    bool PlayerPassThrow;
    bool PizzaBoxPassThrow;
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim.SetBool("Active", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPassThrow&& PizzaBoxPassThrow)
        {
            Anim.SetBool("Active", true);
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Player" )
        {
            PlayerPassThrow = true;
        
        }

        if(other.transform.tag == "PizzaBox")
        {
            PizzaBoxPassThrow = true;
        }
    }


}
