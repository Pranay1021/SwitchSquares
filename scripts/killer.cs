using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killer : MonoBehaviour
{
   
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Green") == null)
        {
            this.gameObject.SetActive(false);

        }
        if (GameObject.FindGameObjectWithTag("Blue") == null)
        {
            this.gameObject.SetActive(false);

        }
    }
    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "enemy")
        {
            this.gameObject.SetActive(false);
        }
        
    }
}
