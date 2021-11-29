using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("West")) _rotation = Vector3.forward;
        else if (Input.GetButtonDown("East")) _rotation = Vector3.back;
        else _rotation = Vector3.zero;

        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}