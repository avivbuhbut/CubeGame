using UnityEngine;

public class EndButtonChallengeOne : MonoBehaviour
{
    bool PlayerOnButton;
    bool PizzaOnButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (PlayerOnButton && PizzaOnButton)
            {
            Debug.Log("Pizza and player stand on the button");
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.transform.name == "Player")
            {
            PlayerOnButton = true;

            }

            if (other.transform.tag == "PizzaBox")
            {
            PizzaOnButton = true;
            }
        }
    }
