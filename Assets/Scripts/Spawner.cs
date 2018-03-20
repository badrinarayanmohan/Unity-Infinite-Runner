using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] obj;
    public float SpawnMIN = 1f;
    public float SpawnMAX = 2f;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(SpawnMIN, SpawnMAX));
    }

}
