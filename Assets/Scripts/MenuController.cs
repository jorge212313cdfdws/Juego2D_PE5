using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Salir()
    {
        Application.Quit();
    }
}