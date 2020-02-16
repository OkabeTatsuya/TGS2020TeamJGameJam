using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int playerID = 0;
     public float PlayerSpeed = 1.0f; //playerのスピード
    public int hitpoint = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.m_gameStop)
        {
            if (playerID == 1)
            {
                //左スッティク 移動処理
                float x = Input.GetAxis("Horizontal");
                float y = Input.GetAxis("Vertical");
                transform.Translate(PlayerSpeed * x, PlayerSpeed * y, 0);


            }

            if (playerID == 2)
            {
                //左スッティク 移動処理
                float x = Input.GetAxis("Horizontal2");
                float y = Input.GetAxis("Vertical2");
                transform.Translate(PlayerSpeed * x, PlayerSpeed * y, 0);


            }

            DesPlayer();

        }



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

    void PlayeHundler()
    {
        if (Input.GetAxis("GamePad"+ playerID + "Horizontal") > 0)
        {
            transform.Translate(PlayerSpeed, 0, 0);

        }

        if (Input.GetAxis("GamePad" + playerID + "Horizontal") < 0)
        {
            transform.Translate(-PlayerSpeed, 0, 0);
        }

        //上の処理
        if (Input.GetAxis("GamePad" + playerID + "Vertical") > 0)
        {
            transform.Translate(0, PlayerSpeed, 0);
        }

        //下の処理
        if (Input.GetAxis("GamePad" + playerID + "Vertical") < 0)
        {
            transform.Translate(0, -PlayerSpeed, 0);
        }
    }

    void DesPlayer()
    {
        if (hitpoint <= 0)
        {
            if (playerID != 1)
            {
                GameManager.Instance.m_winerPlayerID = 1;
            }
            else
            {
                GameManager.Instance.m_winerPlayerID = 2;
            }
            GameManager.Instance.m_gameEnd = true;
            GameManager.Instance.m_gameStop = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hitpoint--;
        }
    }
}
