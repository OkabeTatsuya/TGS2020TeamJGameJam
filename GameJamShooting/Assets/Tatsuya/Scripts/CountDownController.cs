using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownController : MonoBehaviour
{
    public GameObject m_CountDownCanvas;
    public GameObject[] m_Images;
    public float m_CurrentCountDownTime;
    public float m_startDisplayTime;
    private float m_currentStartDisplayTime;
    // Start is called before the first frame update
    void Start()
    {
        m_Images = new GameObject[6];
        for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
        {
            m_Images[i] = m_CountDownCanvas.transform.GetChild(i).gameObject;
            if (i > 0)
            {
                m_Images[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_currentStartDisplayTime <= m_startDisplayTime)
        {
            m_CurrentCountDownTime += Time.deltaTime;
            if (m_CurrentCountDownTime >= 5)
            {
                m_currentStartDisplayTime += Time.deltaTime;
                for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
                {
                    if (i != 5)
                    {
                        m_Images[i].SetActive(false);
                    }
                    else
                    {
                        m_Images[i].SetActive(true);
                    }
                }
                if (m_currentStartDisplayTime >= m_startDisplayTime)
                {
                    Destroy(m_CountDownCanvas);
                }
            }
            else if (m_CurrentCountDownTime >= 4)
            {
                for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
                {
                    if (i != 4)
                    {
                        m_Images[i].SetActive(false);
                    }
                    else
                    {
                        m_Images[i].SetActive(true);
                    }
                }
            }
            else if (m_CurrentCountDownTime >= 3)
            {
                for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
                {
                    if (i != 3)
                    {
                        m_Images[i].SetActive(false);
                    }
                    else
                    {
                        m_Images[i].SetActive(true);
                    }
                }
            }
            else if (m_CurrentCountDownTime >= 2)
            {
                for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
                {
                    if (i != 2)
                    {
                        m_Images[i].SetActive(false);
                    }
                    else
                    {
                        m_Images[i].SetActive(true);
                    }
                }
            }
            else if (m_CurrentCountDownTime >= 1)
            {
                for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
                {
                    if (i != 1)
                    {
                        m_Images[i].SetActive(false);
                    }
                    else
                    {
                        m_Images[i].SetActive(true);
                    }
                }
            }
            else if (m_CurrentCountDownTime >= 0)
            {
                for (int i = 0; i < m_CountDownCanvas.transform.childCount; i++)
                {
                    if (i != 0)
                    {
                        m_Images[i].SetActive(false);
                    }
                    else
                    {
                        m_Images[i].SetActive(true);
                    }
                }
            }
        }
    }
}