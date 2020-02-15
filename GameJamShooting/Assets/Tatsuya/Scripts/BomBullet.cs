using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomBullet : MonoBehaviour
{
    //弾の移動方向のベクトル
    private Vector2 m_movedir;
    //弾の移動速度
    private float m_moveSpeed = 3.0f;
    //消える時間の上限
    private float m_DestroyTime = 2.0f;
    //生成されてからの現在の経過時間
    private float m_currentDestroyTime;

    private void Awake()
    {
        //インスタンスの作成の際に移動方向をランダムに決める
        m_movedir = new Vector2(Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        transform.position += ((Vector3)m_movedir).normalized * Time.deltaTime * m_moveSpeed;
        //時間経過による消滅処理
        m_currentDestroyTime += Time.deltaTime;
        if (m_currentDestroyTime >= m_DestroyTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //壁にぶつかった時の反射処理
        if (collision.gameObject.tag == "Wall")
        {
            //壁に対し垂直方向上向きから当たった時に反射させる
            m_movedir = m_movedir + (Vector2)collision.transform.up * 2;
        }
        //壁以外のものにぶつかった際の消滅処理
        else
        {
            Destroy(gameObject);
        }
    }
}
