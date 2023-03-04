using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thiskillsblue : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Blue")
        {
          coll.gameObject.SetActive(false);
           
        }
    }
}
