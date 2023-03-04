using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausemenu;
    public AudioSource ads;
   public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ads.Pause();
    }
    public void Play()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        ads.Play();
    }
    public void home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}

