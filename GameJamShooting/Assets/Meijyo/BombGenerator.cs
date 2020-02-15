using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject BombPrefab;

    public float minTime = 0.5f;

    public float maxTime = 2f;

    public float xMinPosition = 0f;

    public float xMaxPosition = 0f;

    public float yMinPosition = 0f;

    public float yMaxPosition = 0f;

    private float interval;

    private float time = 0f;

    void Start()
    {
        interval = 5f;

        interval = GetRandomTime();
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time > interval)
        {
            if (interval > minTime)
            {
                GameObject Bomb = Instantiate(BombPrefab);

                Bomb.transform.position = GetRandomPosition();

                time = 0f;
            }
        }
    }
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMaxPosition, xMinPosition);
        float y = Random.Range(yMaxPosition, yMinPosition);

        return new Vector3(x,y);
    }

    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
}