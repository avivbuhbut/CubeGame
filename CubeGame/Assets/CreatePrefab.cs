using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab : MonoBehaviour
{

    public GameObject FlourGmObj;
    public GameObject WaterGmObj;
    public GameObject PizzaSauce;
    public GameObject DaughAndSauceGamObj;

    public int counterFlour = 0;
    public int counterWater = 0;
    public int counterPizzaSauce = 0;

    public int counterDaughAndSauceDebug = 0;
    // Start is called before the first frame update
    void Start()
    {
       // FlourGmObj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (counterFlour <= 4)
        {
         
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                FlourGmObj.SetActive(true);
                counterFlour++;
                Instantiate(FlourGmObj, new Vector3(FlourGmObj.transform.position.x, FlourGmObj.transform.position.y, FlourGmObj.transform.position.z), Quaternion.identity);

            }
        }


        if (counterWater <= 4)
        {
     
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                WaterGmObj.SetActive(true);
                counterWater++;
                Instantiate(WaterGmObj, new Vector3(WaterGmObj.transform.position.x, WaterGmObj.transform.position.y, WaterGmObj.transform.position.z), Quaternion.identity);

            }

        }


        if (counterPizzaSauce <= 4)
        {

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                PizzaSauce.SetActive(true);
                counterPizzaSauce++;
                Instantiate(PizzaSauce, new Vector3(PizzaSauce.transform.position.x, PizzaSauce.transform.position.y, PizzaSauce.transform.position.z), Quaternion.identity);

            }


          

        }


        if (counterDaughAndSauceDebug <= 4)
        {

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                DaughAndSauceGamObj.SetActive(true);
                counterDaughAndSauceDebug++;
                Instantiate(DaughAndSauceGamObj, new Vector3(DaughAndSauceGamObj.transform.position.x, DaughAndSauceGamObj.transform.position.y, DaughAndSauceGamObj.transform.position.z), Quaternion.identity);

            }

        }
    }
}
