using UnityEngine;

public class FogColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



     void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Player")
        {
            RenderSettings.fogColor = Color.black;
        }
    }
}
