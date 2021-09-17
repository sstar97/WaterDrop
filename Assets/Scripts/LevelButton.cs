using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public GameObject pauseMenu,settingsMenu,menu;
    public Text gameOver, gameOverTxt, scoreTxt;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        Debug.Log("çalıştı");
    }

    public void Main()
    {
        
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("life", 3);
    }

    public void Pause()
    {
        if (menu.activeInHierarchy == false)
        {
            PlayerPrefs.SetInt("mnu", 1);
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Back()
    {
        PlayerPrefs.SetInt("menu", 0);
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Settings()
    {

        settingsMenu.SetActive(true);
        Time.timeScale = 0f;
        
    }

    public void changeTr()
    {
        Text gameOver = gameObject.GetComponent<Text>();
        Text gameOverTxt = gameObject.GetComponent<Text>();
        Text scoreTxt = gameObject.GetComponent<Text>();
        Text scoreTxt2 = gameObject.GetComponent<Text>();
        gameOver.text = "oyun bitti";
        gameOverTxt.text = "kaldıgın yerden devam etmek icin oyna butonuna bas.";
        scoreTxt.text = "skor";
        scoreTxt2.text = "skor";
    }
    
}
