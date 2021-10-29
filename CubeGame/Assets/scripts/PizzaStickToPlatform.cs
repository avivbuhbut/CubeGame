using UnityEngine;

public class PizzaStickToPlatform : MonoBehaviour
{

    public Transform FinishLineCubeTrans;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }


   void OnCollisionEnter(Collision collision)

    {
        
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("Hit Finish LIne!");
     
         

        }

      
        



    }



    }
