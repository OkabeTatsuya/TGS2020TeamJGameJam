using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public bool m_gameStop = false;
    public bool m_gameEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string[] name = Input.GetJoystickNames();
        Debug.Log(name[0]);

        for(int i = 0; i < name.Length; i++)
        {
            if (name[i] != "")
            {
                
            }
        }
    }
}
