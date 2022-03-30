using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFunction : MonoBehaviour
{
    public GameObject routeParc;
    public GameObject routeColruyt;
    public GameObject routeBuildingD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropdownEventHandler(int value)
    {
        if (value == 0)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
        }

        if (value == 1)
        {
            routeParc.SetActive(true);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
        }

        if (value == 2)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(true);
            routeBuildingD.SetActive(false);
        }

        if (value == 3)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(true);
        }
    }
}
