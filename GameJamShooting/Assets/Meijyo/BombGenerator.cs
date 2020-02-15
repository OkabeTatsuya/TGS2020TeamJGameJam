using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject BombPrefab;
    public int m_startCreateCount;
    public int m_maxCreateCount;
    public float minInterval;
    public float interval;
    public float minusInterval;
    public float xMinPosition;
    public float xMaxPosition;                           
    public float yMinPosition;
    public float yMaxPosition;
    int m_currentCreateCount;
    float currentIntervalTime;



    void Start()
    {
        for (int i = 0; i < m_startCreateCount; i++)
        {
            Instantiate(BombPrefab, GetRandomPosition(), Quaternion.identity);
            m_currentCreateCount++;
        }
    }

    void Update()
    {
        if (m_currentCreateCount < m_maxCreateCount)
        {
            currentIntervalTime += Time.deltaTime;

            if (currentIntervalTime >= interval)
            {

                Instantiate(BombPrefab, GetRandomPosition(), Quaternion.identity);

                m_currentCreateCount++;

                currentIntervalTime = 0f;

                interval -= minusInterval;

            }

            if (interval <= minInterval)
            {
                interval = minInterval;
            }
        }
    }
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMaxPosition, xMinPosition);
        float y = Random.Range(yMaxPosition, yMinPosition);

        return new Vector3(x,y);
    }

    public void MinusCurrentCreateCount()
    {
        m_currentCreateCount --;
    }

}