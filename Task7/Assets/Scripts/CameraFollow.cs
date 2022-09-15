using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float camSpeed;
    public UIinput uiinput;

    void Update()
    {
        if(uiinput.gamneStart == true)
        {
            transform.Translate(Vector3.forward * camSpeed * Time.deltaTime);
        }
    }
}
