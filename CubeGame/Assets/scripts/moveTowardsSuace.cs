using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsSuace : MonoBehaviour
{

    Vector3 scaleChangeBiger;
    Vector3 scaleChangeSmaller;

    Vector3 StartPosEnemy;
    public Transform SauceTrans;
    public Transform CubeEnemySauceTrans;
    bool ColidedWithSouce;
    bool ColidedWithIngrediens;
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

        NewEnemyMoveTowardsPlayer();



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


            CubeEnemySauceTrans.localScale += scaleChangeBiger;
            SauceTrans.localScale += scaleChangeSmaller;

        }
        else
            ColidedWithSouce = false;
    }


    void EnemyDieSauceParentChange()
    {
        /*if the enemy is now dead make the sauce go to the original sauce parent agian*/
        if (CubeEnemySauceTrans.GetComponent<Enemy1Health>().health == 0)
        {
            SauceTrans.parent = GameObject.Find("PizzaIngridians").gameObject.transform;
            ColidedWithSouce = false;
        }

    }


    void ColidWithSauce()
    {
        /*if the enemy didnt colided with the sauce move towards the sauce, else - move towards bounds*/
        if (!(ColidedWithSouce) && transform.name != "NewEnemy")
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Sauce").transform.position, .9f * Time.deltaTime); // move towards the pizza box

     

    }


    void NewEnemyMoveTowardsPlayer()
    {
        if (NewEnemy != null)
            NewEnemy.position = Vector3.MoveTowards(NewEnemy.position, GameObject.Find("Player").transform.position, .9f * Time.deltaTime);
    }

     void OnCollisionEnter(Collision collision)

    {


        if (collision.gameObject.transform.name == "Dough" || collision.gameObject.transform.name == "Water"
            || collision.gameObject.transform.name == "DoughAndSauce" || collision.gameObject.transform.name == "CubeEnemyWater")
        {

            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
            ColidedWithIngrediens = true;

            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
        }
        else
            ColidedWithIngrediens = false;



        if (collision.gameObject.transform.tag== "Sauce")
        {

            ColidedWithSouce = true;

           // GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("CubeEnemy").transform;
        }else
            ColidedWithSouce = false;
    }
}
