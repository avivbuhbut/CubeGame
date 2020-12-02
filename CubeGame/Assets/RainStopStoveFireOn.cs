using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainStopStoveFireOn : MonoBehaviour
{

    public ParticleSystem FireStove1ParticleSystem;
    public ParticleSystem FireStove2ParticleSystem;

    bool ColiderRainIsHittingStove;

    int counterStartParticale = 1;
    // Start is called before the first frame update
    void Start()
    {

        FireStove1ParticleSystem.Stop();
        FireStove2ParticleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("CubeCheckForRainColision").GetComponent< CubeCheckForRainHit>().hit.transform.name == this.transform.name)
        {



            FireStove1ParticleSystem.Stop();
            FireStove2ParticleSystem.Stop();
            counterStartParticale = 1;

        }
        else
        {
            if (counterStartParticale == 1)
            {

                FireStove1ParticleSystem.Play();
                FireStove2ParticleSystem.Play();
                counterStartParticale++;
            }
        }
    }

    
   

   


}
