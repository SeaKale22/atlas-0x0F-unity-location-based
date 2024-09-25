using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.Experimental.Lightship.AR.WorldPositioning;
using UnityEngine.XR.ARFoundation;

public class CoordsTracker : MonoBehaviour
{
    [SerializeField] private ARCameraManager _arCameraManager;
    
    private ARWorldPositioningCameraHelper _WPSCameraHelper;

    // doubles to hold cords
    private double _latitude;
    private double _longitude;
    private double _altitude;

    public double savedLatitude;
    public double savedLongitude;
    
    // Start is called before the first frame update
    void Start()
    {
        // get WPSCamHelper component
        _WPSCameraHelper = _arCameraManager.GetComponent<ARWorldPositioningCameraHelper>();
        if (_WPSCameraHelper)
        {
            Debug.Log("WPSCamHelper found");
        }
        else
        {
            Debug.Log("WPSCamHelper NOT found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // set coords every frame
        _latitude = _WPSCameraHelper.Latitude;
        _longitude = _WPSCameraHelper.Longitude;
        _altitude = _WPSCameraHelper.Altitude;
    }
    
    // getters for coords
    public double LatitudeGet()
    {
        Debug.Log($"Latitude: {_latitude}");
        return _latitude;
    }
    
    public double LongitudeGet()
    {
        Debug.Log($"Longitude: {_longitude}");
        return _longitude;
    }

    public double AltitudeGet()
    {
        Debug.Log($"Altitude: {_altitude}");
        return _altitude;
    }

    // method to save current lat and long
    public void SaveCurrentCoords()
    {
        savedLatitude = _latitude;
        Debug.Log($"Saved Latitude: {savedLatitude}");
        savedLongitude = _longitude;
        Debug.Log($"Saved Longitude: {savedLongitude}");
    }
}
