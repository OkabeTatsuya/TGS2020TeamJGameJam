using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public GameObject[] m_player;
    public Vector3[] m_startPos;
    public bool[] m_setPosFlag;

    public bool debugCreate;
    public bool debugStart;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePlayer();
    }

    void GeneratePlayer()
    {
        for (int i = 0; i < TitleManager.m_playerPadID.Length; i++)
        {
            if (TitleManager.m_playerPadID[i] != 0)
            {
                var player = Instantiate(m_player[i]);
                player.transform.position = m_startPos[i];
                player.GetComponent<PlayerControl>().playerID = TitleManager.m_playerPadID[i];
            }
        }
    }

}
