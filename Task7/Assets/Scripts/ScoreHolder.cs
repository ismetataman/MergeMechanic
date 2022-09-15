using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreHolder : MonoBehaviour
{
    public UIinput uiinput;
    public Merge merge;
    public ReflectedScoreHolder refscoreholder;
    public GameObject mergedPlayer;
    public float big;
    private int _score=0;
    public int _totalScore;
    public TextMeshProUGUI scoreText;
    private void Update() 
    {
        _totalScore = _score + refscoreholder.reflectedScore;
        scoreText.text = _totalScore.ToString();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Burger") && merge.canScore == true)
        {
            _score ++;
            Destroy(other.gameObject);

            mergedPlayer.transform.localScale = new Vector3(mergedPlayer.transform.localScale.x + _totalScore * big,
                                                mergedPlayer.transform.localScale.y +_totalScore * big,
                                                mergedPlayer.transform.localScale.z + _totalScore * big );


        }
        if(other.gameObject.CompareTag("Wall"))
        {
            //Lose Screen
            uiinput.gamneStart = false;
            SceneManager.LoadScene(0);
        }
    }
}
