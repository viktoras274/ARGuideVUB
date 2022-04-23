using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFunction : MonoBehaviour
{
/*    public GameObject routeParc;
    public GameObject routeColruyt;

    public GameObject routeBuildingD;
    public GameObject routeBuildingE;
    public GameObject routeCafeteria;
    public GameObject routeBuildingK;*/

    public GameObject routeDtoG;
    public GameObject routeGtoK;

    public GameObject GPSStageDtoG;
    public GameObject GPSStageGtoK;

    public GameObject routeTrilofos;
    public GameObject GPSStageTrilofos;

    public GameObject routeTrilofos2;
    public GameObject GPSStageTrilofos2;

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
/*            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
            routeBuildingE.SetActive(false);
            routeCafeteria.SetActive(false);
            routeBuildingK.SetActive(false);*/
            routeGtoK.SetActive(false);
            routeDtoG.SetActive(false);

            GPSStageDtoG.SetActive(false);
            GPSStageGtoK.SetActive(false);

            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);
        }

        if (value == 1)
        {
            /*            routeParc.SetActive(true);
                        routeColruyt.SetActive(false);
                        routeBuildingD.SetActive(false);
                        routeBuildingE.SetActive(false);
                        routeCafeteria.SetActive(false);
                        routeBuildingK.SetActive(false);*/
            routeDtoG.SetActive(true);
            routeGtoK.SetActive(false);

            GPSStageDtoG.SetActive(true);
            GPSStageGtoK.SetActive(false);


            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);
        }

        if (value == 2)
        {
/*            routeParc.SetActive(false);
            routeColruyt.SetActive(true);
            routeBuildingD.SetActive(false);
            routeBuildingE.SetActive(false);
            routeCafeteria.SetActive(false);
            routeBuildingK.SetActive(false);*/
            routeDtoG.SetActive(false);
            routeGtoK.SetActive(true);

            GPSStageDtoG.SetActive(false);
            GPSStageGtoK.SetActive(true);

            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);
        }

        if (value == 3)
        {
            /*            routeParc.SetActive(false);
                        routeColruyt.SetActive(false);
                        routeBuildingD.SetActive(true);
                        routeBuildingE.SetActive(false);
                        routeCafeteria.SetActive(false);
                        routeBuildingK.SetActive(false);
                        routeDtoG.SetActive(false);

                        routeTrilofos.SetActive(false);
                        GPSStageTrilofos.SetActive(false);

                        routeTrilofos2.SetActive(false);
                        GPSStageTrilofos2.SetActive(false);*/

            routeDtoG.SetActive(false);
            routeGtoK.SetActive(false);

            GPSStageDtoG.SetActive(false);
            GPSStageGtoK.SetActive(false);

            routeTrilofos.SetActive(true);
            GPSStageTrilofos.SetActive(true);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);

        }

        if (value == 4)
        {
            /*            routeParc.SetActive(false);
                        routeColruyt.SetActive(false);
                        routeBuildingD.SetActive(false);
                        routeBuildingE.SetActive(true);
                        routeCafeteria.SetActive(false);
                        routeBuildingK.SetActive(false);
                        routeDtoG.SetActive(false);

                        routeTrilofos.SetActive(false);
                        GPSStageTrilofos.SetActive(false);

                        routeTrilofos2.SetActive(false);
                        GPSStageTrilofos2.SetActive(false);*/

            routeDtoG.SetActive(false);
            routeGtoK.SetActive(false);

            GPSStageDtoG.SetActive(false);
            GPSStageGtoK.SetActive(false);

            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(true);
            GPSStageTrilofos2.SetActive(true);
        }

       /* if (value == 5)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
            routeBuildingE.SetActive(false);
            routeCafeteria.SetActive(true);
            routeBuildingK.SetActive(false);
            routeDtoG.SetActive(false);

            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);
        }

        if (value == 6)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
            routeBuildingE.SetActive(false);
            routeCafeteria.SetActive(false);
            routeBuildingK.SetActive(true);
            routeDtoG.SetActive(false);

            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);
        }

        if (value == 7)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
            routeBuildingE.SetActive(false);
            routeCafeteria.SetActive(false);
            routeBuildingK.SetActive(false);
            routeDtoG.SetActive(true);

            routeTrilofos.SetActive(true);
            GPSStageTrilofos.SetActive(true);

            routeTrilofos2.SetActive(false);
            GPSStageTrilofos2.SetActive(false);
        }

        if (value == 8)
        {
            routeParc.SetActive(false);
            routeColruyt.SetActive(false);
            routeBuildingD.SetActive(false);
            routeBuildingE.SetActive(false);
            routeCafeteria.SetActive(false);
            routeBuildingK.SetActive(false);

            routeTrilofos.SetActive(false);
            GPSStageTrilofos.SetActive(false);

            routeTrilofos2.SetActive(true);
            GPSStageTrilofos2.SetActive(true);
        }*/

    }
}
