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
    // the point goal
    public int scoregoal = 5;
    
    
    private void Start()
    {
    //a tutorial told me to do this
        if(instance == null)
        {
            instance = this;
        }
    }
    //adds score and displays it
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        scoreDisplay.text = "Score: "+score.ToString();
    }

    private void Update()
    {
    //checks if player completes the level
        if (score >= scoregoal)
        {
            Debug.Log("vitory!");
            LoadNextLevel();
        }
    }
    public void LoadNextLevel() //loads the next scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartOver()  //starts the game again
    {
        SceneManager.LoadScene(0);
    }
}
