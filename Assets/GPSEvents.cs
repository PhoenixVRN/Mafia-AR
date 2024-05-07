using System;
using UnityEngine;
using UnityEngine.Events;

public class GPSEvents : MonoBehaviour
{
    [SerializeField] private OnlineMapsLocationService locationService;

    [SerializeField] private UnityEvent OnUnityEventLocationChange;
    public event Action OnLocationChange;

    void Awake()
    {
        locationService.OnLocationChanged += (e) =>
        {
            OnLocationChange?.Invoke();
            OnUnityEventLocationChange?.Invoke();
        };
    }
}