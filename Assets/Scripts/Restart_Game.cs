using UnityEngine;

public class Restart_Game : MonoBehaviour
{
   public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f; 
    }

}
