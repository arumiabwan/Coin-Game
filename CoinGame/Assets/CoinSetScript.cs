using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSetScript : MonoBehaviour {

    public Transform Basecoin;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < 150; i++)
        {
            Vector3 offset = new Vector3(Random.value * 10, 0, Random.value * 5);
            Instantiate(Basecoin, transform.position +offset , transform.rotation);
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.C)) {

            for (int i = 0; i < 100; i++)
            {
                Vector3 offset = new Vector3(Random.value * 10, 0, Random.value * 5);
                Instantiate(Basecoin, transform.position + offset, transform.rotation);
            }

        }

	}
}
