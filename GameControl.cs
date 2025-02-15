using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    // This method will be called when the Exit button is clicked
    public void ExitApplication()
    {
        // Exits the game if it's built as a standalone application
        Application.Quit();
        
        // Log a message to the console when running in the Unity editor (just for testing)
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    // This method will be called when the Play button is clicked
    public void RestartGame()
    {
        // Reloads the current scene, effectively restarting the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
