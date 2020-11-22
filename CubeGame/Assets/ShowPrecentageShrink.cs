using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowPrecentageShrink : MonoBehaviour
{

    public TextMeshPro SouceTMP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int counterPresent = 100;
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.name == "CubeEnemy") {
            ExampleCoroutine();
            counterPresent= counterPresent-10;
            SouceTMP.color = Color.red;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
              }
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);
    }


    }
