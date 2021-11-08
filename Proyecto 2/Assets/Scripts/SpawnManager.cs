using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPos = new Vector3(0, 0, 20);
    public int animalIndex;
    public float randomX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void spawnRandomAnimal()
    {
        randomX = Random.Range(-20, 20);
        spawnPos = new Vector3(randomX, 0, 20);
        //aleatoriedad de los animales
        animalIndex = Random.Range(0, animalPrefabs.Length);
        //Spawneo de los animales
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
