using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    // Start is called before the first frame update
    public int pointscollect = 1;
   

    private void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            Scoremanager.instance.ChangeScore(pointscollect);
            
        }

        if (other.gameObject.CompareTag("Green"))
        {
            Scoremanager.instance.ChangeScore(pointscollect);
            
        }
    }



}
 