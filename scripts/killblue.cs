using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killblue : MonoBehaviour
{
    public int score1=0;
    public Text ScoreText;
    public AudioSource ad;
    


    private void Start()
    {
        ad = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        ScoreText.text = ("      ")+((int)score1).ToString();
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {

       

        if (coll.gameObject.tag == "bluecircle")
        {
            Destroy(coll.gameObject);
            score1++;
            ad.Play();
        }

        if (coll.gameObject.tag == "greencircle")
        {
            Destroy(coll.gameObject);
            score1++;
            ad.Play();
        }

    }
}
