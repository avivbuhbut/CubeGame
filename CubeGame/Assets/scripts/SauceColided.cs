using UnityEngine;

public class SauceColided : MonoBehaviour
{

    public bool SauceHitFloor;
    public bool SauceHitSauceShelff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
            SauceHitFloor = true;
        else
            SauceHitFloor = false;

        if (collision.gameObject.name == "SauceShelf")
            SauceHitSauceShelff = true;
        else
            SauceHitSauceShelff = false;
    }
}
