using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sq1;
    public GameObject sq2;

    int x = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {



            if (x == 0)
            {
                sq1.GetComponent<Rigidbody2D>().gravityScale = -3;
                sq2.GetComponent<Rigidbody2D>().gravityScale = 3;
                sq2.GetComponent<gre>().speed = 13;
                sq1.GetComponent<control>().speed = -13;
                x = 1;
            }
            else if (x > 0)
            {
                sq1.GetComponent<Rigidbody2D>().gravityScale = 3;
                sq1.GetComponent<control>().speed = 13;
                sq2.GetComponent<Rigidbody2D>().gravityScale = -3;
                sq2.GetComponent<gre>().speed = -13;
                x = 0;
            }


        }
    }

        public void playerconfigontouch()
        {
            if (x == 0)
            {
                sq1.GetComponent<Rigidbody2D>().gravityScale = -3;
                sq2.GetComponent<Rigidbody2D>().gravityScale = 3;
                sq2.GetComponent<gre>().speed = 13;
                sq1.GetComponent<control>().speed = -13;
                x = 1;
            }
            else if (x > 0)
            {
                sq1.GetComponent<Rigidbody2D>().gravityScale = 3;
                sq1.GetComponent<control>().speed = 13;
                sq2.GetComponent<Rigidbody2D>().gravityScale = -3;
                sq2.GetComponent<gre>().speed = -13;
                x = 0;
            }
        
    }


}
