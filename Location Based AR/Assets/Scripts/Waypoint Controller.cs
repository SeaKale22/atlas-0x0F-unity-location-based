using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.Experimental.Lightship.AR.WorldPositioning;

public class WaypointController : MonoBehaviour
{
    [SerializeField] ARWorldPositioningObjectHelper positioningHelper;
    public CoordsTracker coordsTracker;
    public GameObject WaypointPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCubeAtSavedCoords()
    {
        // get saved coords
        double longitude = coordsTracker.savedLongitude;
        double latitude = coordsTracker.savedLatitude;
        Debug.Log($"Coords Obtained. Lat: {latitude} , Long: {longitude}");
        // using cam relative positioning
        double altitude = 0.0;
        // instantiate waypoint gameObject
        GameObject waypoint = Instantiate(WaypointPrefab);
        // update waypoints location
        positioningHelper.AddOrUpdateObject(waypoint, latitude, longitude, altitude, Quaternion.identity);
        Debug.Log($"Cube created at: {waypoint.transform.position}");
        
    }
}
