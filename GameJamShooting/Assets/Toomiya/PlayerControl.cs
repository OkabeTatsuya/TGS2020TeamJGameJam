using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

     public float PlayerSpeed = 1.0f; //playerのスピード



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //右の処理
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(PlayerSpeed, 0, 0);
        }

        //左の処理
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-PlayerSpeed, 0, 0);
        }

        //上の処理
        if(Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(0, PlayerSpeed, 0);
        }

        //下の処理
        if(Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(0, -PlayerSpeed, 0);
        }



    }
}
