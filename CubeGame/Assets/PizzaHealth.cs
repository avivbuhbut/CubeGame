using UnityEngine;
using UnityEngine.UI;
public class PizzaHealth : MonoBehaviour
{
    public Image bar;
     float fill =1;
    public RaycastHit hitUp;
    public RaycastHit hitDown;
    float timeExposedToRain=1;
    public Transform CanvasTrans;
    float maxBarAfterfall;
    float f;

    // Start is called before the first frame update
    void Start()
    {
        bar.fillAmount  = 1;
        maxBarAfterfall = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //  bar.fillAmount = fill;

        if (maxBarAfterfall < 0)
            maxBarAfterfall = 0;

        if (this.transform.GetComponent<Rigidbody>().velocity.magnitude > 0)
        {
            CanvasTrans.gameObject.SetActive(false);
        }
        else
        {
            CanvasTrans.gameObject.SetActive(true);
        }

        CanvasTrans.position = new Vector3(this.transform.position.x, this.transform.position.y+0.7f, this.transform.position.z);



        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hitUp)){
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * hitUp.distance, Color.yellow);
      //      Debug.Log("Above Pizza: " + hitUp.transform.tag);
        }


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hitDown))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hitDown.distance, Color.yellow);
//            Debug.Log("Above Pizza: " + hitDown.transform.tag);
        }


        timeExposedToRain += 0.2f * Time.deltaTime;

        bool LifeDown = false ;

      


        if (hitUp.transform.tag == "Bounds" && hitDown.transform.tag =="Floor" ||
           hitUp.transform.tag == "Floor" && hitDown.transform.tag == "Bounds")
        {


            if ((Mathf.Round(timeExposedToRain % 2) == 0) && LifeDown==false)
            {
                LifeDown = true;
                bar.fillAmount -= 0.0002f;
  
            }

            if ((Mathf.Round(timeExposedToRain % 1) == 0))
            {
                LifeDown = false;
           
            }

          
          

        }


        if (hitUp.transform.tag != "Bounds" && hitDown.transform.tag =="Floor" ||
           hitUp.transform.tag == "Floor" && hitDown.transform.tag != "Bounds")
        {



            if ((Mathf.Round(timeExposedToRain % 2) == 0) && LifeDown == false && bar.fillAmount<=maxBarAfterfall)
            {
                Debug.Log("maxBarAfterfall: " + maxBarAfterfall);
                LifeDown = true;
                bar.fillAmount += 0.0002f;

            }

            if ((Mathf.Round(timeExposedToRain % 1) == 0))
            {
                LifeDown = false;

            }




        }










    }



    void OnCollisionEnter(Collision collision)
    {
//        Debug.Log(collision.relativeVelocity.magnitude);

        if (collision.relativeVelocity.magnitude > 10)
        {
            bar.fillAmount -= 0.07f;
            maxBarAfterfall -= 0.07f;

        }


    }
}
