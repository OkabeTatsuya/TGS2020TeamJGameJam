using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

     public float PlayerSpeed = 3.0f; //playerのスピード



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //左スッティク 移動処理
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(PlayerSpeed * x, PlayerSpeed * y, 0);




        ////左スティク 右の処理
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    transform.Translate(PlayerSpeed, 0, 0);
        //}

        ////左スティク 左の処理
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    transform.Translate(-PlayerSpeed, 0, 0);
        //}

        ////左スティク 上の処理
        //if (Input.GetAxis("Vertical") > 0)
        //{
        //    transform.Translate(0, PlayerSpeed, 0);
        //}

        ////左スティク 下の処理
        //if (Input.GetAxis("Vertical") < 0)
        //{
        //    transform.Translate(0, -PlayerSpeed, 0);
        //}





    }
}
