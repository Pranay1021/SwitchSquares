using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameovercanvassetactive : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Green") == null)
        {

            canvas.SetActive(true);
        }
        if (GameObject.FindGameObjectWithTag("Blue") == null)
        {

            canvas.SetActive(true);
        }
    }
}
