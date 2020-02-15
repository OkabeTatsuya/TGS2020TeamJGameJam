using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController: MonoBehaviour
{
    public GameObject m_BombBullet;
    public int m_BulletCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameObject.Find("BombGenerator").GetComponent<BombGenerator>().MinusCurrentCreateCount();
            Destroy(gameObject);
            for (int i = 0; i < m_BulletCount; i++)
            {
                Instantiate(m_BombBullet,transform.position,Quaternion.identity);
            }
        }
    }
}
