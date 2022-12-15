using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class objetsSpawner : MonoBehaviour
    {
        public List<Transform> spawnPoints = new List<Transform>();

        public List<GameObject> gameObjectsToSpawn = new List<GameObject>();

        public float spawnRate = 1.0f;

        void Start()
        {
            spawnObj();
        }

        public void spawnObj()
        {
            int numGameObjectsToSpawn = Random.Range(3, gameObjectsToSpawn.Count);

            for (int i = 0; i < numGameObjectsToSpawn; i++)
            {
                int spawnPointIndex = Random.Range(0, spawnPoints.Count);
                int gameObjectToSpawnIndex = Random.Range(0, gameObjectsToSpawn.Count);

                spawnPoints.Remove(spawnPoints[spawnPointIndex]);

                Instantiate(gameObjectsToSpawn[gameObjectToSpawnIndex], spawnPoints[spawnPointIndex].position, Quaternion.identity);
            }
        }
    }
}