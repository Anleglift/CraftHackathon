using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownSelection : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public bool OK1 = false;
    public bool OK2 = false;
    public bool OK3 = false;
    public bool OK4 = false;
    public bool OK5 = false;
    public bool OK6 = false;
    private void Start()
    {
        // Register the onValueChanged event for the dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int dropdownIndex)
    {
        string selectedOption = dropdown.options[dropdown.value].text;

        // Perform different actions based on the selected option
        switch (selectedOption)
        {
            case "None":
                ActionForOption1();
                break;
            case "Programmer":
                ActionForOption2();
                break;
            case "Backend Developer":
                ActionForOption3();
                break;
            case "Designer":
                ActionForOption4();
                break;
            case "Project Manager":
                ActionForOption5();
                break;
            case "Marketing Manager":
                ActionForOption6();
                break;
            default:
                break;
        }
    }

    public void ActionForOption1()
    {
        OK1=true;
        OK2 = false;
        OK3 = false;
        OK4 = false;
        OK5 = false;
        OK6 = false;
        Debug.Log("Coaie");
    }

    public void ActionForOption2()
    {
        OK1 = false;
        OK2 = true;
        OK3 = false;
        OK4 = false;
        OK5 = false;
        OK6 = false;
    }

    private void ActionForOption3()
    {
        OK1 = false;
        OK2 = false;
        OK3 = true;
        OK4 = false;
        OK5 = false;
        OK6 = false;

    }
    private void ActionForOption4()
    {
        OK1 = false;
        OK2 = false;
        OK3 = false;
        OK4 = true;
        OK5 = false;
        OK6 = false;
    }
    private void ActionForOption5()
    {
        OK1 = false;
        OK2 = false;
        OK3 = false;
        OK4 = false;
        OK5 = true;
        OK6 = false;
    }
    private void ActionForOption6()
    {
        OK1 = false;
        OK2 = false;
        OK3 = false;
        OK4 = false;
        OK5 = false;
        OK6 = true;
    }
}
