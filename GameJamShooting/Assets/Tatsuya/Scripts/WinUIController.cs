using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinUIController: MonoBehaviour
{
    public void DrawUI(int ID)
    {
        if (ID <= transform.childCount&&ID>=1)
        {
            transform.GetChild(ID - 1).gameObject.SetActive(true);
        }
    }
}
