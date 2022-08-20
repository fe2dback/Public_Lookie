using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonDownCustom : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private const float tReduceItem = 0.5f;
    bool bCheck = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        bCheck = true;
        StartCoroutine(WaitAndSendSignal());
    }

    private IEnumerator WaitAndSendSignal()
    {
        yield return new WaitForSeconds(tReduceItem);
        if(bCheck == true)
        {
            MobileTouch.OnPointerLongPushed(transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Split('\n')[0]);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        bCheck = false;
    }

}
