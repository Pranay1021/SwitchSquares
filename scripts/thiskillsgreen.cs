using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thiskillsgreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Green")
        {
            coll.gameObject.SetActive(false) ;

        }
    }
}
