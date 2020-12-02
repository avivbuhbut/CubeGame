using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        RaycastHit hit;
        if (Camera.main != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                    ///Very Useful Code! - tells the object name when clicked by the mouse

            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);

            if (hit.transform.name == "Drawn Mesh")
                if (Input.GetKeyDown(KeyCode.Delete))
                {
                    Destroy(hit.transform.gameObject);
                }

        }


    }
}
