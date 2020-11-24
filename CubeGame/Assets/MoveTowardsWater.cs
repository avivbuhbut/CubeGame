using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsWater : MonoBehaviour
{


    Vector3 scaleChangeBiger;
    Vector3 scaleChangeSmaller;

    Vector3 StartPosEnemy;
    public Transform WaterTrans;
    public Transform WaterEnemyTrans;
    bool ColidedWithWater;

    int NewEnemyCounter = 0;
    Transform NewEnemy;

    bool ColidedWithIngrediens;
    // Start is called before the first frame update
    void Start()
    {
        scaleChangeBiger = new Vector3(0.001f, 0.001f, 0.001f);
        scaleChangeSmaller = new Vector3(-0.001f, -0.001f, -0.001f);
        StartPosEnemy = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {


        ColidWithWater();

        EnemyDieWaterParentChange();

        changeCubeAndEnemyScale();


        EnemyColidWithWaterCreateNewEnemyMoveToPlayer();

        byPassIngrediens();

        NewEnemyMoveTowardsPlayer();


  
    }


    void byPassIngrediens()
    {
        if (ColidedWithIngrediens)
        {
 
        }
    }




    void EnemyColidWithWaterCreateNewEnemyMoveToPlayer()
    {

        if (ColidedWithWater && NewEnemyCounter < 1)
        {
            NewEnemyCounter++;
            NewEnemy = Instantiate(WaterEnemyTrans.transform, StartPosEnemy, Quaternion.identity);
            NewEnemy.name = "WaterEnemy";
            NewEnemy.position = Vector3.MoveTowards(NewEnemy.position, GameObject.Find("Player").transform.position, .9f * Time.deltaTime);


        }
    }

    void changeCubeAndEnemyScale()
    {

        /*if the sauce scale is bigger than 1 keep decresing it  - else turn of the colision (to stop the decresing of the sauce and icresing of the enemy)*/
        if (ColidedWithWater && WaterTrans.localScale.x > 0)
        {


            WaterEnemyTrans.transform.localScale += scaleChangeBiger;
            WaterTrans.localScale += scaleChangeSmaller;

        }
        else
            ColidedWithWater= false;
    }


    void EnemyDieWaterParentChange()
    {
        /*if the enemy is now dead make the sauce go to the original sauce parent agian*/
     
            if (WaterEnemyTrans.GetComponent<Enemy1Health>().health == 0)
            {
                GameObject.Find("Water").gameObject.transform.parent = GameObject.Find("PizzaIngridians").gameObject.transform;
                ColidedWithWater = false;
            }
        

    }


    void ColidWithWater()
    {
        /*if the enemy didnt colided with the sauce move towards the sauce, else - move towards bounds*/
        if (!(ColidedWithWater) && transform.name != "WaterEnemy")
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Water").transform.position, .9f * Time.deltaTime); // move towards the pizza box
     
  
    }


    void NewEnemyMoveTowardsPlayer()
    {
        if (NewEnemy != null)
            NewEnemy.position = Vector3.MoveTowards(NewEnemy.position, GameObject.Find("Player").transform.position, .9f * Time.deltaTime);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.tag == "Water")
        {
            Debug.Log(" WaterTrans.localScale.x : " + WaterTrans.localScale.x);
            ColidedWithWater = true;

            // GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("CubeEnemy").transform;
        }
       // else
          //  ColidedWithWater = false;


     
        if (collision.gameObject.transform.name == "Dough" || collision.gameObject.transform.name == "Sauce"
            || collision.gameObject.transform.name == "DoughAndSauce" || collision.gameObject.transform.name == "CubeEnemySauce")

            
        {

            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
            ColidedWithIngrediens = true;

           
        }else
            ColidedWithIngrediens = false;
    }

}
