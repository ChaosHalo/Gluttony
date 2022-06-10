using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Randomgeneration : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform[] spawnPoints;
    public GameObject[] rewardings;
    public GameObject punishments;
    public float spawnTime = 3f;
    public float nextSpawn = 20f;

    void Start()
    {
        //InvokeRepeating("spawnPrefeb", 0, nextSpawn);
        spawnPrefeb();
    }

    void spawnPrefeb()
    {
        //int Index = Random.Range(0, spawnPoints.Length);
        //Instantiate(spawnGameObject, spawnPoints[Index].position,spawnPoints[Index].rotation);
        for (int j = 0; j < rewardings.Length; j++)
        {
            int num = Random.Range(8, 10);

            for (int i = 0; i < num; i++)
            {
                Instantiate(rewardings[j],
                                new Vector3(Random.Range(-15f, 2f), 5f, Random.Range(-100f, 100f)),
                                Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
