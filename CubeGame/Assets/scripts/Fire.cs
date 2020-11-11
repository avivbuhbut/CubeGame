using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public Camera Player1Cam;
    public GameObject bullet;

    Vector3 clickPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clickPos = Vector3.one;
            Vector3 punktA = new Vector3(1, 2, 0);
            Vector3 punktB = new Vector3(2, 1, 0);
            Vector3 punktC = new Vector3(3, 3, 0);
            Plane plane = new Plane(punktA, punktB, punktC);
            Ray ray = Player1Cam.ScreenPointToRay(Input.mousePosition);
            float DistanceToPlane;
            if (plane.Raycast(ray, out DistanceToPlane))
            {
                clickPos = ray.GetPoint(DistanceToPlane);
            }
            Vector3 finalClickPos = new Vector3(clickPos.x, clickPos.y, 1);
            Instantiate(bullet, transform.position, Quaternion.LookRotation(finalClickPos));

        }
        }
    }
