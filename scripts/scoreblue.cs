using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreblue : MonoBehaviour
    
{
    public AudioSource ad;
    private void Start()
    {
        ad = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "greencircle")
        {
            Destroy(this.gameObject);
            ad.Play();
        }
    }
}