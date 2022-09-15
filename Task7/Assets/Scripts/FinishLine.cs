using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject winScreen;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Merge"))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }    
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
