using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaShowTooltip : MonoBehaviour
{
    public OnlineMapsMarker3D _marker;
    void Start()
    {
        // _marker = GetComponent<OnlineMapsMarker3D>();
        _marker.OnClick += OnAreaClick;
    }

    private void OnAreaClick(OnlineMapsMarkerBase marker)
    {
        Debug.Log($"Marker {marker.ToString()}");
        // if (!AllowShowTooltip()) return;
        //
        // OnlineMapsTooltipDrawerBase.tooltipMarker = _marker;
        // _tooltipDrawer.DrawTooltip(TooltipView, Area);
    }
}
