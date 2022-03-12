using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheels : MonoBehaviour
{
    //----Vehicle Wheel Rotation----//
    public KeyCode right = KeyCode.D;
    public KeyCode left = KeyCode.A;
    public float speed = 10.0f;
    //-----------------------------//
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(right))
            transform.Rotate(Vector3.up, speed * Time.deltaTime);

        if (Input.GetKeyDown(left))
            transform.Rotate(-Vector3.up, speed * Time.deltaTime);
    }
}
