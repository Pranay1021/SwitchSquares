using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotdestroy : MonoBehaviour
{

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (GameObject.FindGameObjectWithTag("Green") == null)
        {
            Destroy(this.gameObject);

        }
        if (GameObject.FindGameObjectWithTag("Blue") == null)
        {

            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag =="border")
        {
            Destroy(this.gameObject);
        }
    }
}
