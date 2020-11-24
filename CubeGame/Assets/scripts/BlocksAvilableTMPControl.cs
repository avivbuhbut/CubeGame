using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BlocksAvilableTMPControl : MonoBehaviour
{

    public TextMeshPro PlayerBlocksAvilableTMP;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBlocksAvilableTMP.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CreateBlocks.BlocksAvilable==0)
            PlayerBlocksAvilableTMP.enabled = false;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.name == "BuildingCube(Clone)")
        {
            CreateBlocks.BlocksAvilable++;

            PlayerBlocksAvilableTMP.enabled = true;
            PlayerBlocksAvilableTMP.text = "X" + CreateBlocks.BlocksAvilable + " Blocks";
           // GameObject.Find("BuildingCube").SetActive(false);
        }
    }
}
