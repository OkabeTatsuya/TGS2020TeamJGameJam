using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    float BulletSpeed = 30.0f;
    Vector3 moveDir;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += moveDir * Time.deltaTime * BulletSpeed;

    }

    public void SetMoveDir(Vector3 RStickDir)
    {
        moveDir = RStickDir.normalized;
        transform.up = moveDir.normalized;
    }

}
