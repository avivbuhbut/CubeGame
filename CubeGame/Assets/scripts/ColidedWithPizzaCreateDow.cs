using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidedWithPizzaCreateDow : MonoBehaviour
{

    public Transform PizzaFluerTrans;
    public GameObject PizzaWaterGamObj;
    public GameObject DoughGameObj;
    // Start is called before the first frame update
    void Start()
    {
        DoughGameObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.tag == "Water")
        {
        
            Instantiate(DoughGameObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            DoughGameObj.SetActive(true);
            Destroy(PizzaWaterGamObj);
            Destroy(this.gameObject);

        }
    }
}
