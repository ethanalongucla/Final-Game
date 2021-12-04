using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] public float _speed = 10;
    [SerializeField] public float rotationSpeed = 1.0f;

    // Update is called once per frame
    private void Update()
    {
        float _rotation = Input.GetAxis("LT") * rotationSpeed;

        transform.Rotate(0, _rotation * _speed * Time.deltaTime, 0);
        //Cursor.UpdateAllNavMesh();//Auto reconfigure navmesh after rotating
    }
}