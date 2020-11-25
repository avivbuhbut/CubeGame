using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public AudioSource PlayAudioRain;
    // Start is called before the first frame update
    void Start()
    {
        PlayAudioRain.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
