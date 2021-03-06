﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGlenerator : MonoBehaviour
{

    public GameObject Bullet;
    public GameObject Player;

    PlayerControl m_playerScript;

    public float m_generateCoolTime;
    private float m_currentGenerateCoolTime;

    //プレイヤーからどの程度離すか
    public float m_generateDistance;

    // Start is called before the first frame update
    void Start()
    {
        m_playerScript = Player.GetComponent<PlayerControl>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.m_gameStop)
        {
            var playerID = m_playerScript.playerID;
            m_currentGenerateCoolTime += Time.deltaTime;
            //右スティック 弾の処理
            float Rx = Input.GetAxis("RHorizontal" + playerID);
            float Ry = -Input.GetAxis("RVertical" + playerID);
            Debug.Log(Rx + "" + Ry);
            if ((Rx != 0 || Ry != 0) && m_currentGenerateCoolTime >= m_generateCoolTime)
            {
                Vector3 createDir = new Vector3(Rx, Ry, 0);
                Vector3 a = createDir.normalized * m_generateDistance;
                m_currentGenerateCoolTime = 0;
                GameObject bullet = Instantiate(Bullet, Player.transform.position + a, Quaternion.identity);
                bullet.GetComponent<BulletControl>().SetMoveDir(createDir);
            }
        }
    }
}
