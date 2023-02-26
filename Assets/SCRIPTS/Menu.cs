
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject play;

    bool pause;

    public void Boton()
    {
        Time.timeScale = 1;
    }
    public void escena()
    {
        SceneManager.LoadScene("menu");
    }
    public void scene()
    {
        SceneManager.LoadScene("scene");
       
        Time.timeScale = 1f;
    }
    public void scene2()
    {
        SceneManager.LoadScene("scene2");
        
        Time.timeScale = 1f;
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Pause()
    {
        play.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        play.SetActive(false);
        Time.timeScale = 1f;
    }
   
}
