using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher_move : MonoBehaviour {

    private Vector3 origin;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        origin = transform.position;
        rb = this.GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 offset = new Vector3(0, 0, 3*Mathf.Sin(Time.time)-1);

        //transform.position = origin + offset;
        rb.MovePosition(origin + offset);
      

        


    }
}
