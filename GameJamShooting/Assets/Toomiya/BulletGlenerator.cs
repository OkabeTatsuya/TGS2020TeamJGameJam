using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGlenerator : MonoBehaviour
{

    public GameObject Bullet;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //右スティック 弾の処理
        float Rx = Input.GetAxis("RHorizontal");
        float Ry = -Input.GetAxis("RVertical");
        //Debug.Log("bb");//確認用
        if (Rx != 0 || Ry != 0)
        {
            GameObject bullet = Instantiate(Bullet,Player.transform.position,Quaternion.identity);
            bullet.GetComponent<BulletControl>().SetMoveDir(new Vector3(Rx, Ry, 0));
        }
    }
}
