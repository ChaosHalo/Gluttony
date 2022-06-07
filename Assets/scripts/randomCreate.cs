using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class randomCreate : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform[] spawnPoints;
    public GameObject[] rewardings;
    public GameObject punishments;
    public float spawnTime = 3f;
    public float nextSpawn = 2f;
    void Start()
    {
        spawnPrefeb();
    }

    void spawnPrefeb()
    {
        //int Index = Random.Range(0, spawnPoints.Length);
        //Instantiate(spawnGameObject, spawnPoints[Index].position,spawnPoints[Index].rotation);
        for (int j = 0; j < rewardings.Length; j++)
        {
            int num = Random.Range(0, 10);

            for (int i = 0; i < num; i++)
            {
                Instantiate(rewardings[j],
                                new Vector3(Random.Range(0f, 10f), 1, Random.Range(0f, 10f)), 
                                Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        //InvokeRepeating("spawnPrefeb",spawnTime,nextSpawn);

    }
}
