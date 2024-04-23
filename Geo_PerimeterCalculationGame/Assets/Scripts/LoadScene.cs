using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Restart()
    {
        // Aktif sahneyi yeniden y�kle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        // Oyundan ��k
        Application.Quit();
    }
}
