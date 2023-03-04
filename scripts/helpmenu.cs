using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpmenu : MonoBehaviour
{
    public GameObject helpmenu1;
    public GameObject start;

    // Update is called once per frame
    public void help()
    {
        helpmenu1.SetActive(true);
        start.SetActive(false);
    }
}
