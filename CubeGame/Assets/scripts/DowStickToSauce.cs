using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DowStickToSauce : MonoBehaviour
{
    public GameObject SauceTransGamObj;
    public GameObject DoughAndSauceGamObj;

    // Start is called before the first frame update
    void Start()
    {
        DoughAndSauceGamObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.transform.tag == "Sauce")
        {

            DoughAndSauceGamObj.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            Instantiate(DoughAndSauceGamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            DoughAndSauceGamObj.SetActive(true);

     
            this.gameObject.SetActive(false);

        }
    }


}
