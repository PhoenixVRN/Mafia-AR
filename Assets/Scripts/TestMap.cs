using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YandexMaps;

public class TestMap : MonoBehaviour
{
    public RawImage Image;
    public Map.TypeMap TypeMap;
    public Map.TypeMapLayer TypeMapLayer;
    public List<Vector2> Markers = new List<Vector2>();

    public int Size;
    public float Lat;
    public float Lon;
    
 
    public void LoadMap()
    {
        Map.EnabledLayer = true;
        Map.Size = Size;
        Map.SetTypeMap = TypeMap;
        Map.SetTypeMapLayer = TypeMapLayer;
        Map.SetMarker = Markers;
        Map.Latitude = Lat;
        Map.Longitude = Lon;
        Map.LoadMap();
        StartCoroutine(LoadTexture());
    }

    IEnumerator LoadTexture()
    {
        yield return new WaitForSeconds(1f);
        Image.texture = Map.GetTexture;
    }
}
