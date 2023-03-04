using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startspawn : MonoBehaviour
{
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void spawn()
    {
        spawner.SetActive(true);   
    }
}
