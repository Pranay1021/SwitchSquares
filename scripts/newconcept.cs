using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newconcept : MonoBehaviour
{
   
    public SpriteRenderer sr;
    public GameObject redsq;
    public SpriteRenderer sp1;
    public GameObject bluesq;
    private int x;
    
    // Start is called before the first frame update
    void Start()
    {
        
        sr = GetComponent<SpriteRenderer>();
        sp1=redsq.GetComponent<SpriteRenderer>();
        x = 1;
        sr.color = new Color(0.4588236f, 0.5294118f, 0.9254903f, 1);
        bluesq.transform.tag = "Blue";

        sp1.color = new Color(0.9058824f, 0.5104575f, 0.4313726f, 1);
       redsq.transform.tag = "Green";

        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Switch();
        }
    }
    public void Switch()
    {
        if (x > 1)
        {
            redsq.transform.tag = "Green";
            bluesq.transform.tag = "Blue";
            sr.color = new Color(0.4588236f, 0.5294118f, 0.9254903f, 1);
          
            
            sp1.color = new Color(0.9058824f, 0.5104575f, 0.4313726f, 1);
            
            Debug.Log("tag cahnged");
           
            x = 1;
        }
        else if (x == 1)
        {
            redsq.transform.tag = "Blue";
            bluesq.transform.tag = "Green";
            sr.color = new Color(0.9058824f, 0.5104575f, 0.4313726f, 1);
            
            sp1.color =new Color(0.4588236f, 0.5294118f, 0.9254903f, 1);
            
            x = 3;
            Debug.Log("tag changed");
        }
       
       
    }

}
