using UnityEngine;
using System.Collections;

public class PlayerMovment : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovmentCotrol();
    }


    void PlayerMovmentCotrol()
    {

        if (Input.GetKeyDown("space"))
        {
           transform.Translate(Vector3.up * 8f * Time.deltaTime, Space.World);
         }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.Self); //LEFT
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.Self); //RIGHT
        }
    }
}