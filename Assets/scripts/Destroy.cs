using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Food")//using the tag to select the object
        {
            Destroy(other.gameObject);//in case for to many foods in boo`s mouth
        }
        Debug.Log("explode" + other.gameObject.name);
    }
}