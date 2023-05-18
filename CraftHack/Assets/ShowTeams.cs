using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTeams : MonoBehaviour
{
    public DropdownSelection DropdownSelection;
    public GameObject Programmers;
    public GameObject Backend;
    public GameObject Designer;
    public GameObject Project;
    public GameObject Marketing;
    public GameObject None;
    // Start is called before the first frame update
    void Start()
    {
        Programmers.SetActive(false);
        Backend.SetActive(false);
        Designer.SetActive(false);
        Project.SetActive(false);
        Marketing.SetActive(false);
        None.SetActive(false);
    }
    public void Generate()
    {
        if (DropdownSelection.OK1== true)
        {
            None.SetActive(true);
            Programmers.SetActive(false);
            Backend.SetActive(false);
            Designer.SetActive(false);
            Project.SetActive(false);
            Marketing.SetActive(false);
        }
         if (DropdownSelection.OK2 == true)
        {
            Programmers.SetActive(true);
            Backend.SetActive(false);
            Designer.SetActive(false);
            Project.SetActive(false);
            Marketing.SetActive(false);
            None.SetActive(false);

        }
        if (DropdownSelection.OK3 == true)
        {
            Programmers.SetActive(false);
            Backend.SetActive(true);
            Designer.SetActive(false);
            Project.SetActive(false);
            Marketing.SetActive(false);
            None.SetActive(false);

        }
        if (DropdownSelection.OK4 == true)
        {
            Programmers.SetActive(false);
            Backend.SetActive(false);
            Designer.SetActive(true);
            Project.SetActive(false);
            Marketing.SetActive(false);
            None.SetActive(false);

        }
        if (DropdownSelection.OK5 == true)
        {
            Programmers.SetActive(false);
            Backend.SetActive(false);
            Designer.SetActive(false);
            Project.SetActive(true);
            None.SetActive(false);

            Marketing.SetActive(false);
        }
        if (DropdownSelection.OK6 == true)
        {
            Programmers.SetActive(false);
            Backend.SetActive(false);
            Designer.SetActive(false);
            None.SetActive(false);

            Project.SetActive(false);
            Marketing.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
