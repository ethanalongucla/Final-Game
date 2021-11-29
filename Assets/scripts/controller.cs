using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("North")) { Debug.Log("North"); }
        if (Input.GetButtonDown("South")) { Debug.Log("South"); }
        if (Input.GetButtonDown("West")) { Debug.Log("West"); }
        if (Input.GetButtonDown("East")) { Debug.Log("East"); }

        Vector3 left = new Vector3(Input.GetAxis("LeftJoyX"), Input.GetAxis("LeftJoyY"), 0);
        Vector3 right = new Vector3(Input.GetAxis("RightJoyX"), Input.GetAxis("RightJoyY"), 0);

        Debug.Log(left + "," + right);
    }
}