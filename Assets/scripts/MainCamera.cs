using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float speed = 3.0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        //get input
        Vector3 joy = new Vector3(Input.GetAxis("LeftJoyX"), Input.GetAxis("LeftPad"), -Input.GetAxis("LeftJoyY"));

        //camera vectors
        Vector3 up = Camera.main.transform.up;
        Vector3 forward = Camera.main.transform.forward;
        Vector3 vertical = Vector3.ProjectOnPlane(up, Vector3.forward);
        Debug.DrawRay(transform.position, vertical * 10, Color.red);
        Vector3 project = Vector3.ProjectOnPlane(forward, Vector3.up);
        Debug.DrawRay(transform.position, project * 10, Color.blue);
        Vector3 right = Camera.main.transform.right;
        Debug.DrawRay(transform.position, right * 10, Color.green);

        //only continue if joystick pressed moe than 0.3f
        if (joy.magnitude < 0.3f) { return; }
        Debug.Log("camera Move");
        //move camera
        Vector3 move = right * joy.x + vertical * joy.y + project * joy.z;
        transform.Translate(move * Time.deltaTime * speed);
        Debug.DrawRay(transform.position, move, Color.red);
    }
}