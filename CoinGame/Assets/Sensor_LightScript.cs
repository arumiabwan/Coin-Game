using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor_LightScript : MonoBehaviour {

    private Vector3 origin;
    public static Vector3 offset_sensor_light;

	// Use this for initialization
	void Start () {
        origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = origin + offset_sensor_light;

	}
}
