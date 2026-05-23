using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public float fallLimit = -10f;

    void Update()
    {
        if (transform.position.y < fallLimit)
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}