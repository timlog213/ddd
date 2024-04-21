using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Media;
using UnityEngine;

public class Route : MonoBehaviour
{
    public RoutePoint nextPoint;
    public GameObject model;
    public bool isActiveForPlayer;
    void OnTriggerEnter (Collider other)
    {
        if(gameObject.tag = "Player")
        {
            isActiveForPlayer = false;
            model.SetActive(false);
            nextPoint.isActiveForPlayer = true;
            nextPoint.model.SetActive(true);
        }
    }
}
