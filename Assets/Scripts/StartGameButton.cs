using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public static void LoadScene(int indexScene) 
    {
        SceneManager.LoadScene(indexScene);
        Time.timeScale = 1f;
    
    }
}
