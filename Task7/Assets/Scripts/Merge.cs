using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge : MonoBehaviour
{
    public GameObject reflectedPlayer;
    public GameObject mergedPlayer;
    public GameObject mergeSplash;
    public GameObject splitSplash;
    public bool canScore;

    private int splashCounter = 0;
    private int splitSplashCounter = 0;
    

     private void Start() {
          canScore = true;
     }
    private void Update() 
    {
       if(splashCounter == 2)
       {
            mergeSplash.SetActive(false);
       }
       if(splitSplashCounter == 2)
       {
            splitSplash.SetActive(false);
       }
    }
   private void OnTriggerEnter(Collider other) 
   {
        if(other.gameObject.CompareTag("Merge"))
        {
            canScore = false;
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            reflectedPlayer.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            reflectedPlayer.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            mergedPlayer.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            splashCounter = 1;
            mergeSplash.SetActive(true);
            splitSplashCounter = 2;
        }
   }
   

   private void OnTriggerExit(Collider other) 
   {
         if(other.gameObject.CompareTag("Merge"))
        {
            canScore = true;
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            reflectedPlayer.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            reflectedPlayer.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            mergedPlayer.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            splashCounter = 2;
            splitSplash.SetActive(true);
            splitSplashCounter = 1;


        }
   }

}
