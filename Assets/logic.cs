using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{

    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase score")]
    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
    public void restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
