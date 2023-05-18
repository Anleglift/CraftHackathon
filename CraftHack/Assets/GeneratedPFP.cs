using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GeneratedPFP : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI textToEdit;

    private void Start()
    {
        // Register the onValueChanged event for the dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int dropdownIndex)
    {
        // Get the selected option text
        string selectedOption = dropdown.options[dropdown.value].text;

        // Edit the text based on the selected option
        switch (selectedOption)
        {
            case "Programmer":
                textToEdit.text = "Programmer";
                break;
            case "Backend Developer":
                textToEdit.text = "BackendDeveloper";
                break;
            case "Designer":
                textToEdit.text = "Designer";
                break;
            case "Project Manager":
                textToEdit.text = "Project Manager";
                break;
            case "Marketing Manager":
                textToEdit.text = "Marketing Manager";
                break;
            default:
                textToEdit.text = "Default Text";
                break;
        }
    }

}
