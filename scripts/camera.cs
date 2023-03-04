using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float camspeed;
    private float scoreboost;
    private int givtim = 1;

    private float initializationTime;

    void Start()
    {
        initializationTime = Time.timeSinceLevelLoad;
    }
    void Update()
    {
        float timeSinceInitialization = Time.timeSinceLevelLoad - initializationTime;
    
    
       
        transform.position += new Vector3(camspeed*Time.deltaTime, 0,0);
        if (timeSinceInitialization > givtim)
        {
            camspeed = camspeed + 1f;
            givtim = givtim + 10;
        }
        else
        {
            camspeed = camspeed;
        }
    }
}
