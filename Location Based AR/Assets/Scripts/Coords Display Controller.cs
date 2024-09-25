using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoordsDisplayController : MonoBehaviour
{
    public TMP_Text latitudeText;
    public TMP_Text longitudeText;
    public TMP_Text altitudeText;
    public TMP_Text savedLatText;
    public TMP_Text savedLongText;

    public CoordsTracker coordsTracker;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        latitudeText.text = $"Latitude: {coordsTracker.LatitudeGet()}";
        longitudeText.text = $"Longitude: {coordsTracker.LongitudeGet()}";
        altitudeText.text = $"Altitude: {coordsTracker.AltitudeGet()}";
    }

    // method to display the saved coords
    public void SetSavedCoords()
    {
        savedLatText.text = $"Saved Latitude: {coordsTracker.savedLatitude}";
        savedLongText.text = $"Saved Longitude: {coordsTracker.savedLongitude}";
    }
}
