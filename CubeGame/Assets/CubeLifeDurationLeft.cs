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
        CubeLifeDurationTmp.text = (int)this.transform.GetComponent<WaterDamage>().timeLeft + "S";
    }
}
