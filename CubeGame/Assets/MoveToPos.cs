using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPos : ColidedScript
{


    [SerializeField] Animator animAtor;
    // Start is called before the first frame update
    void Start()
    {
        animAtor.SetBool("Activate", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 3)
            animAtor.SetBool("Activate", true);

    }
}
