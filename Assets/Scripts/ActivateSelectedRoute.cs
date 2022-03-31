using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateSelectedRoute : MonoBehaviour
{
    public GameObject activeRoute;

    public void ActivateRoute()
    {
        if (activeRoute.activeSelf != true)
        {
            activeRoute.SetActive(true);
        }
        else
        {
            activeRoute.SetActive(false);
        }
    }


}
