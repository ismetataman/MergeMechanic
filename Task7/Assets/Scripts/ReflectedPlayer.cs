using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectedPlayer : MonoBehaviour
{
    public Transform originalObject;
    public Transform reflectedObject;
    void Update()
    {
        reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.left);
    }
}
