
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menue : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitGame()
    {
        Debug.Log("Игра закончилась");
        Application.Quit();
    }
}
