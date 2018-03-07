using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*機能
 
    重なり判定は「Coin」タグが付いているものが"当たって"かつ"出るとき"
    On_countは重なり判定が出るたびに加算
    On_countがある限りslotを回すことができる
    slotを回したらOn_countを一つ減らす

 */


public class Sensor : MonoBehaviour {

    private Vector3 origin;

    public static Vector3 offset_sensor;

    public static int On_count=1;

    public bool on_check;

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Coin")
        {
            On_count++;
            Debug.Log(other.name + "Exit");
        }
    }


    // Use this for initialization
    void Start () {

        //origin = transform.position;
        //offset_sensor = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        //offset = pm1.offsetcopy;
        //offset = new Vector3(0, 0, 3 * Mathf.Sin(Time.time) - 1);
       
        //transform.position = origin + offset_sensor;

        //重なリ判定
       



	}
}
