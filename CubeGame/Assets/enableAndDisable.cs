using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableAndDisable : MonoBehaviour
{
    
    public GameObject DrawGameObj;
    // Start is called before the first frame update

    int counter = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
           DrawGameObj.SetActive(true);
            this.transform.GetComponent<Draw>().enabled = true;
            this.transform.GetComponent<LineRenderer>().enabled = true;
        }
        //Instantiate(DrawGameObj, new Vector3(1, 1, 1), Quaternion.identity);
        else
        {

           // DrawGameObj.transform.GetComponent<Draw>().enabled = false;
           // DrawGameObj.transform.GetComponent<LineRenderer>().enabled = false;
        }

        // this.transform.GetComponent<Draw>().enabled = false;
        // this.transform.GetComponent<LineRenderer>().enabled = false;

    }
}
