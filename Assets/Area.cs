using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public OnlineMapsMarker3D Marker { get; private set; }
    void Start()
    {
        Marker = GetComponentInParent<OnlineMapsMarker3D>();
        Marker.enabled = true;
    }

    
}
