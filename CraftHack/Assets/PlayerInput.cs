using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public TextMeshProUGUI output;
    public bool OK1;
    public bool OK2;
    public bool OK3;
    public bool OK4;
    public bool OK5;
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            OK1 = true;
        }
        if (val == 1)
        {
            OK2 = true;
        }
        if (val == 2)
        {
            OK3 = true;
        }
        if (val == 3)
        {
            OK4 = true;
        }
        if (val == 4)
        {
            OK5 = true;
        }
    }
}