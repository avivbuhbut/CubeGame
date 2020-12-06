using System;
using UnityEngine;



    public class FollowTarget : MonoBehaviour
    { 
    Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);
    Transform originalPlayer;
   // public Transform PlayerCloneTrans;

    //public Transform LatestActivePlayer;



    void Start()
    {
        originalPlayer = GameObject.FindWithTag("Player").transform;
///  '/    GameObject.Find("FinishLevelButton (1)").transform.
        //PlayerCloneTrans.gameObject.SetActive(false);
    }

     void Update()
    {

        originalPlayer = GameObject.FindWithTag("Player").transform;

        // if (originalPlayer == null)
        // if (Input.GetKeyDown(KeyCode.Q))
        //   originalPlayer = GameObject.Find("Player(Clone)").transform;



    }

    void LateUpdate()
    {

        //     if(GameObject.Find("Player").transform.gameObject.activeSelf)

        
        if (originalPlayer != null)
        {

            target = originalPlayer;

            transform.position = target.position + offset;

        }


    }
    }

