using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAnimScript : MonoBehaviour
{
    RaycastHit hit;
    bool DidntHitObjectPlayerPress;
   // public float time = 0;
    AnimationClip anim;
   static Transform DestTrans;
    Transform TransToMove;
    // Use this for initialization
    void Start()
    {
        /*
        Animation anim = GetComponent<Animation>();
        AnimationCurve curve;

        // create a new AnimationClip
        AnimationClip clip = new AnimationClip();
        clip.legacy = true;

        // create a curve to move the GameObject and assign to the clip
        Keyframe[] keys;
        keys = new Keyframe[2];
        keys[0] = new Keyframe(2.0f, this.transform.position.x); // the first variable is the time from point to point , the second variable is the lendth the object it will have to travel
        keys[1] = new Keyframe(1.0f, 1.5f);
      //  keys[2] = new Keyframe(2.0f, 0.0f);
        curve = new AnimationCurve(keys);
        clip.SetCurve("", typeof(Transform), "localPosition.x", curve);


        // update the clip to a change the red color
        curve = AnimationCurve.Linear(0.0f, 1.0f, 2.0f, 0.0f);
        clip.SetCurve("", typeof(Material), "_Color.r", curve);

        // now animate the GameObject
        anim.AddClip(clip, clip.name);
        anim.Play(clip.name);*/


    

    }


     void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                    ///Very Useful Code! - tells the object name when clicked by the mouse

            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            if (hit.transform.name != "BackGround")
            {

                if(hit.transform.tag == "CubeShifter")
                TransToMove = hit.transform;
                Physics.Raycast(ray, out hit);

                if (Input.GetMouseButtonDown(0))
                    DestTrans = hit.transform;

                Debug.Log(DestTrans);


            }
        }


        if (DidntHitObjectPlayerPress == false && DestTrans != null)
        {
            
            
            TransToMove.transform.position = Vector3.MoveTowards(TransToMove.position, new Vector3(DestTrans.transform.position.x, DestTrans.transform.position.y, TransToMove.transform.position.z),
                0.02f);

          //  TransToMove.transform.position = TrVector3.up;


        }
        else
        {
            DidntHitObjectPlayerPress = false;
            DestTrans = null;
        }


        

        // this.transform.position =  Vector3.MoveTowards(transform.position, GameObject.FindWithTag("Player").transform.position, 2f);

    }

    /*
    public static void CreateAnim()
    {
        AnimationClip clip = new AnimationClip();
        clip.SetCurve("", typeof(Transform), "position.x", AnimationCurve.EaseInOut(0, 0, 2, 10));
        clip.SetCurve("", typeof(Transform), "position.y", AnimationCurve.EaseInOut(0, 10, 2, 0));
        clip.SetCurve("", typeof(Transform), "position.z", AnimationCurve.EaseInOut(0, 5, 2, 2));
        AssetDatabase.CreateAsset(clip, "Assets/Test.anim");
    }*/



     void OnTriggerEnter(Collider other)

    {
      

        if (other.transform.name == DestTrans.transform.name)
            DidntHitObjectPlayerPress = true ;
    }


}
