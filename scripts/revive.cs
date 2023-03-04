using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revive : diamonds
{
    public GameObject sqblue;
    public GameObject sqred;
    public GameObject Spawer;
    public AudioSource ads;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
         

    }

    // Update is called once per frame
    void Update()
    {
        

    
    }

   public void Reviver()
    {
        if (diamond > 0)
        {
            sqblue.SetActive(true);
            sqred.SetActive(true);
            Spawer.SetActive(true);
            ads.Play();
            Debug.Log("revived");
            diamond--;
            
        }
        else
        {
            Debug.Log("no diamonds");
        }
    }
}

