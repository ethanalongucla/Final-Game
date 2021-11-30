using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(Manager.Instance.food);
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "food")//
        {
            Destroy(other.gameObject);//
        }
        Debug.Log("explode" + other.gameObject.name);
        Debug.Log(Manager.Instance.food);
    }
}