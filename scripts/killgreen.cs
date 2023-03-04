using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killgreen : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    public AudioSource ad;
    
    // Start is called before the first frame update
    private void Start()
    {
        ad = GetComponent<AudioSource>();
       
    }
    void Update()
    {
        
        scoretext.text = ("      ")+((int)score).ToString();
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "greencircle")
        {
            Destroy(coll.gameObject);
            ad.Play();
            score++;
        }

        if (coll.gameObject.tag == "bluecircle")
        {
            Destroy(coll.gameObject);
            score++;
            ad.Play();
        }

    }
}
