using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenetratePrefab : MonoBehaviour
{

    private Vector3 mousePos;
    private Vector3 objectPos;
    public GameObject myPrefab;
    public Transform Player;
    public float xPos = 8.19f;

    void Start()
    {
     
    }
    
    void Update()
    {
        GeneratePrefab();

    }

    void GeneratePrefab()
    {
        if (Input.GetMouseButton(0))
        {
            // Instantiate(myPrefab, new Vector3(Player.position.x, Player.position.y, Player.position.z), Quaternion.identity);


            Vector3 mousePos = Input.mousePosition;
            mousePos.z = xPos;       // we want 2m away from the camera position
            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);

            Instantiate(myPrefab, objectPos, Quaternion.identity);
        }
    }
}
