using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCoin : MonoBehaviour {

    public static int havecoin=100;


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Coin")
        {
            havecoin++;
            Destroy(other.gameObject);
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
