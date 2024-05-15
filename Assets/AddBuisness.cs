using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBuisness : MonoBehaviour
{
   public OnlineMapsMarker3DManager _marker3DManager;
   public OnlineMapsLocationService _locationServises;
   public GameObject prefabMarker;
   public float lng;
   public float lat;

   public void CreateArea()
   {
      var mark = _marker3DManager.Create(lng, lat, prefabMarker);
      mark.transform.gameObject.GetComponent<AreaShowTooltip>()._marker = mark;
      mark.scale = 10;
   }

   public void RemoveToPlayer()
   {
      _locationServises.allowUpdatePosition = true;
   }
}
