using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownOptions : MonoBehaviour
{
    List<string> names = new List<string>() { " ", "Parc", "Colruyt", "Building D" };

    public Dropdown dropdown;

    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {

        dropdown.AddOptions(names);
    }
}
