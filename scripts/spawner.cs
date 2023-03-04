using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obs;
    public float maxX;
    public float minX;

    public GameObject savme;
   
    
    private float timebetweenspawn;
    private float spawntime=2;
    private float initializationTime;
    private float savemetime;

    void Start()
    {
        initializationTime = Time.timeSinceLevelLoad;
        savemetime = 0;
    }
    void Update()
    {
        float timeSinceInitialization = Time.timeSinceLevelLoad - initializationTime;
    

    // Start is called before the first frame update
   
        float timebetweenspawn = Random.Range(2, 3);
        if (timeSinceInitialization > spawntime)
        {

            spawn();
            spawntime = timeSinceInitialization + timebetweenspawn;

        }
        if (Time.timeSinceLevelLoad > savemetime)
        {
            saveme();
            savemetime = 279;
        }
        if (GameObject.FindGameObjectWithTag("Green") == null || GameObject.FindGameObjectWithTag("Blue")==null)
        {
            this.gameObject.SetActive(false);

        }
        
    }

    // Update is called once per frame
    void spawn()
    {
        float randomx = Random.Range(minX, maxX);
        float randomdownx = Random.Range(minX, maxX);
        int rand = Random.Range(0, obs.Length);
        int randdown = Random.Range(0, obs.Length);
        Instantiate(obs[rand], transform.position + new Vector3(randomx, 0.9f, 10), transform.rotation);
        Instantiate(obs[randdown], transform.position + new Vector3(randomdownx, -0.9f, 10), transform.rotation);
    }
    void saveme()
    {
        float[] same= { -0.9f,0.9f };
        float savex = Random.Range(minX, maxX);
        int savey = Random.Range(0, 2);
        float spawny = same[savey];
        Instantiate(savme, transform.position + new Vector3(savex,spawny, 10), transform.rotation);

    }
}
