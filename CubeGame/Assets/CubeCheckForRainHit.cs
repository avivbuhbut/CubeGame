using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCheckForRainHit : MonoBehaviour
{
    public AudioSource RainAudio;
    public RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(GameObject.Find("CubeCheckForRainColision").transform.position, GameObject.Find("CubeCheckForRainColision").transform.TransformDirection(Vector3.down), out hit))
        {

  
            Debug.DrawRay(GameObject.Find("CubeCheckForRainColision").transform.position, GameObject.Find("CubeCheckForRainColision").transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);

        }
        else
        {
            Debug.DrawRay(GameObject.Find("CubeCheckForRainColision").transform.position, GameObject.Find("CubeCheckForRainColision").transform.TransformDirection(Vector3.down) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }





        if (hit.transform.name == "StoveCelling")
        {
           
            RainAudio.Play();
        }
        else
            RainAudio.Stop();


    }





}
