using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextStayAbovePiz : MonoBehaviour { 


    public Transform PizzaTrans;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(PizzaTrans.transform.position.x, PizzaTrans.position.y, PizzaTrans.transform.position.z);
    }
}
