using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReflectedScoreHolder : MonoBehaviour
{
    public UIinput uiinput;
    public Merge merge;
    public int reflectedScore=0;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Burger") && merge.canScore == true )
        {
            reflectedScore ++;
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Wall"))
        {
            //Lose Screen
            uiinput.gamneStart = false;
            SceneManager.LoadScene(0);
        }
    }
}
