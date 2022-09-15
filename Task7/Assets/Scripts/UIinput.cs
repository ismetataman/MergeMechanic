using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIinput : MonoBehaviour,IDragHandler,IPointerDownHandler
{
    public Transform playerTransform;
    public bool gamneStart = false;
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 temporaryPos = playerTransform.position;
        temporaryPos.x = Mathf.Clamp(temporaryPos.x + eventData.delta.x * 0.005f,-1.8f,1.8f);
        playerTransform.position = temporaryPos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        gamneStart = true;
    }

    
}
