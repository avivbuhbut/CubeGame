using UnityEngine;

public class SlowMotion : MonoBehaviour
{

    float currentAmount = 0f;
    float maxAmount = 5f;
    public bool SlowMotionIsOn;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("z"))
        {
            SlowMotionIsOn = true;
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.3f;

            else

                Time.timeScale = 1.0f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }

        SlowMotionIsOn = false;


        if (Time.timeScale == 0.03f)
        {

            currentAmount += Time.deltaTime;
        }

        if (currentAmount > maxAmount)
        {

            currentAmount = 0f;
            Time.timeScale = 1.0f;

        }

    }
}