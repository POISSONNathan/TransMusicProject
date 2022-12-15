using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Nathan
{
    public class objetsSpawner : MonoBehaviour
    {
        public List<GameObject> gameObjectsToSpawn = new List<GameObject>();

        public List<Transform> spawnPoints = new List<Transform>();

        public List<Transform> spawnPointsLeure = new List<Transform>();

        public Transform spawnObjATouver;

        public int numGameObjectsToSpawn;
        private int gameObjectToSpawnIndex;
        private int gameObjectToSpawnIndex2;

        private LevelManager lm;

        public Text scoreText;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;

            spawnObj();
        }

        void Update()
        {
            scoreText.text = lm.scoreScene.ToString();
        }

        public void spawnObj()
        {
            numGameObjectsToSpawn = Random.Range(3, spawnPoints.Count + 1);
            gameObjectToSpawnIndex = Random.Range(0, gameObjectsToSpawn.Count);

            lm.scoreSceneNeed = numGameObjectsToSpawn;

            for (int i = 0; i < numGameObjectsToSpawn; i++)
            {
                int spawnPointIndex = Random.Range(0, spawnPoints.Count);

                var newObj = Instantiate(gameObjectsToSpawn[gameObjectToSpawnIndex], spawnPoints[spawnPointIndex].position, Quaternion.identity);
                newObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

                spawnPoints.Remove(spawnPoints[spawnPointIndex]);
            }

            var inventaireObj = Instantiate(gameObjectsToSpawn[gameObjectToSpawnIndex], spawnObjATouver.position, Quaternion.identity);
            inventaireObj.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);

            gameObjectsToSpawn.Remove(gameObjectsToSpawn[gameObjectToSpawnIndex]);
            leure();
        }

        public void leure()
        {
            for (int i = 0; i < numGameObjectsToSpawn; i++)
            {
                gameObjectToSpawnIndex2 = Random.Range(0, gameObjectsToSpawn.Count);

                int spawnPointIndex2 = Random.Range(0, spawnPoints.Count);

                var newObj1 = Instantiate(gameObjectsToSpawn[gameObjectToSpawnIndex2], spawnPointsLeure[spawnPointIndex2].position, Quaternion.identity);
                newObj1.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                newObj1.gameObject.GetComponent<objScore>().enabled = false;

                spawnPointsLeure.Remove(spawnPointsLeure[spawnPointIndex2]);
            }
        }
    }
}