using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher_move : MonoBehaviour {

    private Vector3 origin;
    public Rigidbody rb;

    //GameObject refObj;

	// Use this for initialization
	void Start () {
        origin = transform.position;
        //rb = this.GetComponent<Rigidbody>();
        transform.GetComponent<Rigidbody>().velocity = new Vector3(3.0f, 0.0f, 0.0f);

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 offset = new Vector3(0, 0, 2*Mathf.Sin(Time.time)-1);

        //Sensor se1 = refObj.GetComponent<Sensor>();

       Sensor.offset_sensor = offset;//sensorのoffsetをpusherから合わせる
        Sensor_LightScript.offset_sensor_light = offset;

        //transform.position = origin + offset;
        rb.MovePosition(origin + offset);

        //rb.velocity = new Vector3(3.0f, 0.0f, 0.0f); ;
        


    }
}
