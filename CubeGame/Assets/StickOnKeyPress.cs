using UnityEngine;

public class StickOnKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {





        if (CubeShifterScrpt.hit.transform != null)
        {
       
            if (CubeShifterScrpt.hit.transform.tag == "CubeShifter" && ColidedWithAnotherCubeShifter.ColidedWithAnotherCubeShifterbool
            )
            {
                Debug.Log("Inside");
                CubeShifterScrpt.hit.transform.GetComponent<Rigidbody>().isKinematic = true;
            
                 ColidedWithAnotherCubeShifter.ColidedWithTransCubeShifter.transform.GetComponent<Rigidbody>().isKinematic = false;
                CubeShifterScrpt.hit.transform.parent = ColidedWithAnotherCubeShifter.ColidedWithTransCubeShifter.transform;

              //  if(!Input.GetKeyDown(KeyCode.L))
                    this.transform.GetComponent<DragRigidbody>().enabled = false;
                


                if (Input.GetKey(KeyCode.L) && CubeShifterScrpt.hit.transform.tag == "CubeShifter")
                {
                    this.transform.GetComponent<DragRigidbody>().enabled = true;
                
                    CubeShifterScrpt.hit.transform.parent = null;
                    ColidedWithAnotherCubeShifter.ColidedWithAnotherCubeShifterbool = false;
                    CubeShifterScrpt.hit.transform.GetComponent<Rigidbody>().isKinematic = false;
                    CubeShifterScrpt.hit.transform.GetComponent<Rigidbody>().AddForce(-3f, 1f, 0, ForceMode.Impulse); 
                    // ColidedWithAnotherCubeShifter.ColidedWithTransCubeShifter.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                }
            }
        


            if (Input.GetKeyDown(KeyCode.L) && CubeShifterScrpt.hit.transform.tag == "CubeShifter")
            {
                CubeShifterScrpt.hit.transform.parent = null;

                CubeShifterScrpt.hit.transform.GetComponent<Rigidbody>().isKinematic = false;
            }

        }
        
    }



    
}
