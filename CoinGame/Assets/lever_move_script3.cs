using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_move_script3 : MonoBehaviour
{

    //private Vector3 axis_vec;
    static public Vector3 pos = new Vector3(0, 0, 0);
    int left_right, up_down;


    // Use this for initialization
    void Start()
    {

        //axis_vec = transform.position;
        pos = transform.position;
        transform.Rotate(new Vector3(6, 0, 0), 27);
        left_right = 0;
        up_down = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V) && up_down >= -2)//下移動
        {
            transform.Rotate(new Vector3(6, 0, 0), 1);
            up_down--;
        }

        if (Input.GetKey(KeyCode.T) && up_down <= 2)//上移動
        {
            transform.Rotate(new Vector3(6, 0, 0), -1);
            up_down++;
        }

        if (Input.GetKey(KeyCode.G) && left_right <= 16)//右移動
        {
            transform.Rotate(new Vector3(0, 8, 0), 1);
            left_right++;
        }

        if (Input.GetKey(KeyCode.F) && left_right >= 0)//左移動
        {
            transform.Rotate(new Vector3(0, 8, 0), -1);
            left_right--;
        }



        //transform.Rotate(axis_vec,1);

    }
}
