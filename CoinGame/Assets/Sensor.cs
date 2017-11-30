using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour {

    private Vector3 origin;

    public static Vector3 offset_sensor;

    // Use this for initialization
    void Start () {

        origin = transform.position;
        offset_sensor = transform.position;
         
	}
	
	// Update is called once per frame
	void Update () {
        //offset = pm1.offsetcopy;
        //offset = new Vector3(0, 0, 3 * Mathf.Sin(Time.time) - 1);
       
        transform.position = origin + offset_sensor;

	}
}
