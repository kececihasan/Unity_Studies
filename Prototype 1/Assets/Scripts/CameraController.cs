using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject atachedVehicle;
    public GameObject CameraFolder;
    public Transform[] camLocations;
    private float locationIndicator = 2;

    [Range(0,1)]public float smoothTime = .5f;
    // Start is called before the first frame update
    void Start()
    {
        atachedVehicle = GameObject.FindGameObjectWithTag("Player");
        CameraFolder = atachedVehicle.transform.Find("CAMERA").gameObject;
        camLocations = CameraFolder.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (locationIndicator >= 4 || locationIndicator < 2) locationIndicator = 2;
            else locationIndicator ++;
        }

        transform.position = camLocations[(int)locationIndicator].position * (1- smoothTime) + transform.position * smoothTime;
    }
}
