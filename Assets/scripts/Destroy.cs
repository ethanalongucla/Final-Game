using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //Public variable to get the object with the script holding our score
    public ScoreOnDestroy score;

    //Value the object is worth when it is destroyed
    public int pointsToAdd = 1;

    // Use this for initialization
    private void Start()
    {
        //If the score holder was not set then try and grab it from the parent of the script
        /*if (score == null)
        {
            score = GetComponent<ScoreOnDestroy>();
        }*/
    }

    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Food")//using the tag to select the object
        {
            Destroy(other.gameObject);//in case for to many foods in boo`s mouth
                                      //score.AddToScore(pointsToAdd);
        }
        Debug.Log("explode" + other.gameObject.name);
    }
}