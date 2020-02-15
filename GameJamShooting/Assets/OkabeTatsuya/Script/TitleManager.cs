using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    int[] m_gamePadID = { 1, 2, 3, 4 };
    public static int[] m_playerPadID = { 0, 0, 0, 0 };
    public int m_countID = 0;
    public int m_maxCountID = 0;
    int m_mimPlayers = 1;

    // Start is called before the first frame update
    void Start()
    {
        m_playerPadID = new int[] { 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        Hundler();
    }

    void Hundler()
    {
        for (int i = 0; i < Input.GetJoystickNames().Length; i++)
        {
            if (Input.GetButtonDown("GamePad" + m_gamePadID[i] + "_ButtonA") && m_countID <= m_maxCountID)
            {
                Debug.Log("GamePad" + m_gamePadID[i]);

                m_playerPadID[m_countID] = m_gamePadID[i];
                m_countID++;

                //ChecInputPad(m_gamePadID[i]);
            }

            if (m_countID > 0)
            {
                if (Input.GetButtonDown("GamePad" + m_playerPadID[0] + "_ButtonView") && m_countID >= m_mimPlayers)
                {
                    Debug.Log("スタート");
                }
            }
        }

    }

    void ChecInputPad(int itr)
    {
        foreach (var id in m_playerPadID)
        {
            if (id == itr)
            {

            }
            if (m_playerPadID[m_countID] == 0 )
            {
                m_playerPadID[m_countID] = itr;
                m_countID++;
                break;
            }
        }
    }
}
