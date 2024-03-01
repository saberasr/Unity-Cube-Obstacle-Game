using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameOver = false;
    public GameObject WinText;
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void EndGame()
    {
        if (GameOver == false)
        {
            GameOver = true;
            Invoke("RestartGame", 2f);
        }
    }
    public void LevelComplete()
    {
        WinText.SetActive(true);
    }
}
