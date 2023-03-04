using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverandrestart : MonoBehaviour
{
    public GameObject gameover;
    public GameObject buttons;
    public AudioSource ads;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Green") == null)
        {
            gameover.SetActive(true);
            buttons.SetActive(false);
            ads.Pause();
           
            //maingame.SetActive(false);
        }
        else
        {
            gameover.SetActive(false);
            buttons.SetActive(true);
            
        }
        if (GameObject.FindGameObjectWithTag("Blue") == null)
        {
            gameover.SetActive(true);
            buttons.SetActive(false);
            ads.Pause();
            //maingame.SetActive(false);
        }
        else
        {
            gameover.SetActive(false);
            buttons.SetActive(true);
            
            
            //maingame.SetActive(false);
        }


    }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        }
    
}
