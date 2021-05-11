using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWIthPizzaMode : MonoBehaviour
{
    public Transform SecondPlayerTrans;
    public Transform FirstPlayerTrans;
    public Transform PizzaBoxTrans;
    public Camera player1Camera;
    public Camera Player2Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log("first player status: " + FirstPlayerTrans.gameObject.activeSelf);
        Debug.Log("SecondPlayerTrans status: " + SecondPlayerTrans.gameObject.activeSelf);

        if (Input.GetKey(KeyCode.Q) && FirstPlayerTrans.gameObject.activeSelf)
        {
           // FirstPlayerTrans.gameObject.SetActive(false);
          //  player1Camera.gameObject.SetActive(false);

          //  SecondPlayerTrans.gameObject.SetActive(true);
          //  Player2Camera.gameObject.SetActive(true);


            Debug.Log("FirstPlayer -Activating the second one");
            //Transform tran = LastActivePizzaBox.LastPizzaActive.transform;



            FirstPlayerTrans.transform.position = new Vector3(PizzaBoxTrans.transform.position.x, PizzaBoxTrans.transform.position.y + 1, PizzaBoxTrans.transform.position.z);
         

        }


       // if (Input.GetKey(KeyCode.T) && SecondPlayerTrans.gameObject.activeSelf)
        //{
          
          //  SecondPlayerTrans.gameObject.SetActive(false);
          // Player2Camera.gameObject.SetActive(false);


           // FirstPlayerTrans.gameObject.SetActive(true);
          //  player1Camera.gameObject.SetActive(true);

            //Transform tran = LastActivePizzaBox.LastPizzaActive.transform;



//FirstPlayerTrans.transform.position = new Vector3(PizzaBoxTrans.transform.position.x, PizzaBoxTrans.transform.position.y + 1, PizzaBoxTrans.transform.position.z);


        //}

    }
}
