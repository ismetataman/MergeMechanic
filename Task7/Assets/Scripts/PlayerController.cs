using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UIinput uiinput;

    private Rigidbody _rb;
    private Animator _anim;
    
    public float runSpeed;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(uiinput.gamneStart == true)
        {
            _anim.SetBool("canRun",true);
            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
            //transform.position += Vector3.forward * runSpeed *Time.deltaTime;
        }
    }
}
