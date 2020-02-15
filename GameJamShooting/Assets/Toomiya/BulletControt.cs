using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControt: MonoBehaviour
{
    float BulletSpeed = 2.0f;
    Vector3 moveDir;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(moveDir*BulletSpeed);

    }

    public void SetMoveDir(Vector3 RStickDir)
    {
        moveDir = RStickDir.normalized;
    }

}
