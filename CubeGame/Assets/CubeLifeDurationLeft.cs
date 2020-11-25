using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CubeLifeDurationLeft : MonoBehaviour
{


    public TextMeshPro CubeLifeDurationTmp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((int)this.transform.GetComponent<WaterDamage>().timeLeft > 10)
        {
            CubeLifeDurationTmp.color = Color.green;
            CubeLifeDurationTmp.text = (int)this.transform.GetComponent<WaterDamage>().timeLeft + "S";
        }


        if ((int)this.transform.GetComponent<WaterDamage>().timeLeft <= 10
            && (int)this.transform.GetComponent<WaterDamage>().timeLeft > 5)
        {
            CubeLifeDurationTmp.color = Color.green;
            CubeLifeDurationTmp.text = (int)this.transform.GetComponent<WaterDamage>().timeLeft + "S";
        }
        else {

            if ((int)this.transform.GetComponent<WaterDamage>().timeLeft <= 5 &&
               (int)this.transform.GetComponent<WaterDamage>().timeLeft > 2)
            {
                CubeLifeDurationTmp.color = Color.yellow;
                CubeLifeDurationTmp.text = (int)this.transform.GetComponent<WaterDamage>().timeLeft + "S";
            }
            if ((int)this.transform.GetComponent<WaterDamage>().timeLeft < 3)
            {
                CubeLifeDurationTmp.color = Color.red;
                CubeLifeDurationTmp.text = (int)this.transform.GetComponent<WaterDamage>().timeLeft + "S";
            }
        }
   
    }
}
