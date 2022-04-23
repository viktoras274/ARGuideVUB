using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownOptions : MonoBehaviour
{
    /*    List<string> names = new List<string>() { " ", "Parc", "Colruyt", "Building D", "Building E", "Cafeteria", "Building K", "Trilofos", "Trilofos 2" };
    */

    List<string> names = new List<string>() { " ", "D to G", "G to K", "Trilofos", "Trilofos 2" };

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
