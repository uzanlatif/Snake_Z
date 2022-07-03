using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public Snake snakeContainer;
    public int Score;
    public Text TextScore;
    public GameObject UIGameOver;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          snakeContainer.ResetState();
          UIGameOver.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
    }

    public void RestartGame(){
        UIGameOver.SetActive(false);
        snakeContainer.ResetState();
    }

    public void GameOver(){
        UIGameOver.SetActive(true);
        Time.timeScale = 0;
        //popup UI
        UpdateUI();
       
    }

    public void AddScore(){
        Score++;
    }
    public void ResetScore(){
        Score=0;
    }

    public void UpdateUI(){
        TextScore=TextScore.GetComponent<Text>();
        TextScore.text=Score.ToString();
    }
}
