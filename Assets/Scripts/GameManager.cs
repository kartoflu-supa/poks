using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreDisplay;
    int score;
    public int scoregoal = 5;
    
    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        scoreDisplay.text = "Score: "+score.ToString();
    }

    private void Update()
    {
        if (score >= scoregoal)
        {
            Debug.Log("vitory!");
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartOver()
    {
        SceneManager.LoadScene(0);
    }
}
