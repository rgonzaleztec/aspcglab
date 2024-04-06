using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Age_Dropdown : MonoBehaviour
{


    public TMP_Dropdown ageDropdown;
    private int startYear = 1920;
    private int endYear  = 2024;

    // Start is called before the first frame update

    void Start()
    {

        endYear = DateTime.Now.Year;

        //Just in case
        if (endYear <= startYear)
        {
            endYear = 2024;
        }

        PopulateYears(startYear, endYear, ageDropdown);
        
    }


    void PopulateYears(int start, int end, TMP_Dropdown dropdown)
    {
        dropdown.ClearOptions(); // Clear any existing options

        // Create a list to hold the dropdown options
        var options = new List<TMP_Dropdown.OptionData>();

        // Populate the options list with names from the array
       
        for (int i = end; i >= start; i--)
        {
            options.Add(new TMP_Dropdown.OptionData(i.ToString()));
        }

        // Add the options to the dropdown
        dropdown.AddOptions(options);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
