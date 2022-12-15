using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class objetsSpawner : MonoBehaviour
    {
        public List<GameObject> gameObjectsToSpawn = new List<GameObject>();

        public List<Transform> spawnPoints = new List<Transform>();

        public float spawnRate = 1.0f;

        public int numGameObjectsToSpawn;
        public int gameObjectToSpawnIndex;

        private LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;

            spawnObj();
        }

        public void spawnObj()
        {
            numGameObjectsToSpawn = Random.Range(3, spawnPoints.Count + 1);
            gameObjectToSpawnIndex = Random.Range(0, gameObjectsToSpawn.Count);

            lm.scoreSceneNeed = numGameObjectsToSpawn;

            for (int i = 0; i < numGameObjectsToSpawn; i++)
            {
                int spawnPointIndex = Random.Range(0, spawnPoints.Count);

                Instantiate(gameObjectsToSpawn[gameObjectToSpawnIndex], spawnPoints[spawnPointIndex].position, Quaternion.identity);

                spawnPoints.Remove(spawnPoints[spawnPointIndex]);
            }
        }
    }
}