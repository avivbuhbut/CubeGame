using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowMoney : MonoBehaviour
{

    public Transform MoneyTrans;
    public static int i = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (ColidedScript.counter == 3)
        {
            MoneyTrans.gameObject.SetActive(true);

            if (i != 100)
            {
                Transform temoCube = Instantiate(MoneyTrans, new Vector3(this.gameObject.transform.position.x - 18, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);
                temoCube.GetComponent<Rigidbody>().velocity = new Vector3(0, -10, 0);
                // temoCube.GetComponent<Rigidbody>().mass = 5f;
                i++;
            }

        }
    }


}
