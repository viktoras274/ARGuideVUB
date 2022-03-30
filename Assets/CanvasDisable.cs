using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDisable : MonoBehaviour
{
    public GameObject panelController;

    public void DisableCanvas()
    {
        GameObject.Find("VUBPanel");
        panelController.SetActive(false);
    }

    public void EnableCanvas()
    {
        GameObject.Find("VUBPanel");
        panelController.SetActive(true);
    }
}
