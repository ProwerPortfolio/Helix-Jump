using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("LevelProgress:currentLevel");
        PlayerPrefs.DeleteKey("ScoresCollector:scores");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
