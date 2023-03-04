using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerswap : MonoBehaviour

{
    public GameObject sq1;
    public GameObject sq2;
    public Vector3 tempposition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            tempposition = sq1.transform.position;
            sq1.transform.position = sq2.transform.position;
            sq2.transform.position = tempposition;
           
        }

    }
    public void satasat()
    {
        tempposition = sq1.transform.position;
        sq1.transform.position = sq2.transform.position;
        sq2.transform.position = tempposition;
    }
}
