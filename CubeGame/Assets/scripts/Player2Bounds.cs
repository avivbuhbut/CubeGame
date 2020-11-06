using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player2Bounds : MonoBehaviour
{

    public TextMeshPro CantDoThatTMP;

    public Transform Player2;
    public float currentPosX;
    public float currentPosY;
    public float currentPosZ;

    // Start is called before the first frame update
    void Start()
    {

        currentPosX =  gameObject.transform.position.x;
        currentPosY = gameObject.transform.position.y;
        currentPosZ = gameObject.transform.position.z;
   
        /*Text TMP "Cant do that" Control*/
        CantDoThatTMP.gameObject.SetActive(false);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PlateBoundsP2")
        {
            CantDoThatTMP.gameObject.SetActive(true);
            StartCoroutine(ShowMessage(CantDoThatTMP, "CAN'T DO THAT!", 2));
            gameObject.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
          
        }
    }



    IEnumerator ShowMessage(TextMeshPro Text, string message, float delay)
    {
        Text.text = message;
        Text.enabled = true;
        yield return new WaitForSeconds(delay);
        Text.enabled = false;
    }

}
