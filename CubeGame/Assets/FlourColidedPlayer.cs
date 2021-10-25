using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class FlourColidedPlayer : MonoBehaviour
{

    public float speed = 1.0f;
    bool colidedWithPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D)&& colidedWithPlayer == true)
        {
            this.transform.parent = null;
            this.transform.GetComponent<Rigidbody>().isKinematic = false;
            this.transform.GetComponent<Rigidbody>().AddForce(new Vector2(20, 0));
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y  , this.transform.position.z);

        }
        
    


     void OnCollisionEnter(Collision collision)
    {

        if(collision.transform.tag == "Floor")
        {
            colidedWithPlayer = false;
        }


        if (collision.transform.name == "Player" && colidedWithPlayer==false)
        {
            colidedWithPlayer = true;


            //collision.transform.parent = collision.transform;



            this.transform.parent = collision.transform;
            this.transform.GetComponent<Rigidbody>().isKinematic = true;

            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+0.7f  , this.transform.position.z+0.05f);

            transform.localRotation = Quaternion.Euler(transform.localRotation.x, 90, transform.localRotation.z);
        }

    }

}
