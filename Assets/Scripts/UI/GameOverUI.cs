using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoSingleton<GameOverUI>
{
    public GameObject gameoverUI;

    public void BackToMenu()
    {      
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Restart()
    {  
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameoverUI.SetActive(true);
    }
}
