using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillPizzaSauce : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 PizzaSauce100pScale;
    Vector3 fillSauce;

    bool SuaceOnShelf;
    void Start()
    {
        fillSauce = new Vector3(0.001f, 0.001f, 0.001f);
        PizzaSauce100pScale = GameObject.Find("Sauce").transform.localScale;
    }

    // Update is called once per frame
    void Update() 
    {
        if (SuaceOnShelf && GameObject.Find("Sauce").transform.localScale != PizzaSauce100pScale)
            GameObject.Find("Sauce").transform.localScale += fillSauce;
      
        
    }


void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.transform.name == "Sauce")
    {
        SuaceOnShelf = true;
    }

        if (collision.gameObject.transform.name == "Floor")
            SuaceOnShelf = false;
}
}
