using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taptoplay : MonoBehaviour




{

    public float stayTime = 0.5f;
    

   

    public void Start()
    {
       
    }

    void Update()
    {
        

        if (stayTime > 0)
        {
            float alpha = (Mathf.Sin(Time.time * stayTime) + 1.0f) / 2.0f;
            foreach (CanvasRenderer r in GetComponentsInChildren<CanvasRenderer>())
            {
                r.SetAlpha(alpha);
            }
        }
       
    }
}
