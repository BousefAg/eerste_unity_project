using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Waypointnpc : MonoBehaviour
{

    public List<Transform> waypoints;
    private Transform targetwaypoint;
    // Start is called before the first frame update
    void Start()
    {
        targetwaypoint = waypoints[0];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void waypoint(Transform waypoint){
        //zorgen dat het object de waypoint volgt
        Vector3 direction = waypoint.position - transform.position;
    }
}
