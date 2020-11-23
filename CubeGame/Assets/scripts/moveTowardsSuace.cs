using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsSuace : MonoBehaviour
{

    Vector3 scaleChangeBiger;
    Vector3 scaleChangeSmaller;

    Vector3 StartPosEnemy;
    public Transform SauceTrans;
    bool ColidedWithSouce;

    int NewEnemyCounter = 0;
    Transform NewEnemy;
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


        ColidWithSauce();

        EnemyDieSauceParentChange();

        changeCubeAndEnemyScale();


        EnemyColidWithSauceCreateNewEnemyMoveToPlayer();





    }


    void EnemyColidWithSauceCreateNewEnemyMoveToPlayer()
    {

        if (ColidedWithSouce && NewEnemyCounter < 1)
        {
            NewEnemyCounter++;
            NewEnemy = Instantiate(GameObject.Find("CubeEnemySauce").transform, StartPosEnemy, Quaternion.identity);
            NewEnemy.name = "NewEnemy";
            NewEnemy.position = Vector3.MoveTowards(NewEnemy.position, GameObject.Find("Player").transform.position, .9f * Time.deltaTime);


        }
    }

    void changeCubeAndEnemyScale()
    {
        /*if the sauce scale is bigger than 1 keep decresing it  - else turn of the colision (to stop the decresing of the sauce and icresing of the enemy)*/
        if (ColidedWithSouce && SauceTrans.localScale.x > 0)
        {


            GameObject.Find("CubeEnemySauce").transform.localScale += scaleChangeBiger;
            GameObject.Find("Sauce").transform.localScale += scaleChangeSmaller;

        }
        else
            ColidedWithSouce = false;
    }


    void EnemyDieSauceParentChange()
    {
        /*if the enemy is now dead make the sauce go to the original sauce parent agian*/
        if (GameObject.Find("CubeEnemySauce").GetComponent<Enemy1Health>().health == 0)
        {
            GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("PizzaIngridians").gameObject.transform;
            ColidedWithSouce = false;
        }

    }


    void ColidWithSauce()
    {
        /*if the enemy didnt colided with the sauce move towards the sauce, else - move towards bounds*/
        if (!(ColidedWithSouce) && transform.name != "NewEnemy")
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Sauce").transform.position, .9f * Time.deltaTime); // move towards the pizza box
        else
            if (NewEnemy != null)
            NewEnemy.position = Vector3.MoveTowards(NewEnemy.position, GameObject.Find("Player").transform.position, .9f * Time.deltaTime);
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.tag== "Sauce")
        {
            Debug.Log(" SauceTrans.localScale.x : " + SauceTrans.localScale.x);
            ColidedWithSouce = true;

           // GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("CubeEnemy").transform;
        }else
            ColidedWithSouce = false;
    }
}
