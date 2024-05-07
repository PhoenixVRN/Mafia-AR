using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ZoomMaps : MonoBehaviour
{
    [SerializeField] private OnlineMaps _OnlineMaps;
    public Button plus;
    public Button minus;
    public bool IsPressedMinus;

    private void Start()
    {
        plus.onClick.AddListener(PlusZoom);
        minus.onClick.AddListener(MinusZoom);
        // StartCoroutine(ZoomOnButtons());
    }

    private void PlusZoom()
    {
        _OnlineMaps.floatZoom += 1f;
    }

    private void MinusZoom()
    {
        _OnlineMaps.floatZoom -= 1f;
    }
    // private IEnumerator ZoomOnButtons()
    // {
    //     yield return new WaitForSeconds(0.05f);
    //     if (IsPressedPlus)
    //     {
    //         _OnlineMaps.floatZoom += 0.2f;
    //     }
    //     if (IsPressedMinus)
    //     {
    //         _OnlineMaps.floatZoom -= 0.2f;
    //     }
    //     StartCoroutine(ZoomOnButtons());
    // }
}
