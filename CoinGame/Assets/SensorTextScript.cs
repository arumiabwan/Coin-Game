using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      this.GetComponent<Text>().text= "重なった数：" + Sensor.On_count.ToString()+"残りコイン："+RemoveCoin.havecoin.ToString();
	}
}
