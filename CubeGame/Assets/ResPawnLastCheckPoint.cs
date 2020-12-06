using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResPawnLastCheckPoint : MonoBehaviour
{

    
    public GameObject PlayerGamObj;
   // public Camera RainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(PlayerLife.PlayerLifeCounter <= 0 && Input.GetKeyDown(KeyCode.Q))
        {
           GameObject NewPlayer =  Instantiate(PlayerGamObj, new Vector3(this.transform.position.x,this.transform.position.y+1,this.transform.position.z), Quaternion.identity) ;
            PlayerLife.PlayerLifeCounter = 100;
            Camera.main.GetComponent<FollowCamera2Script>().target = NewPlayer.transform;
           // RainCamera.gameObject.SetActive(true);
          //  RainCamera.GetComponent<FollowCamera>().target = NewPlayer.transform.gameObject;

        }
        
    }
}
