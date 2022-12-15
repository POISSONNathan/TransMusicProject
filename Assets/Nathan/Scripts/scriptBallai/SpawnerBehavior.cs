using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class SpawnerBehavior : MonoBehaviour
    {

        public List<GameObject> listPrefab;
        public List<GameObject> createdObjects;

        public int valueSpawnPlus = 6;

        private LevelManager lm;

        private int randomGameobject;
        public int randomValueSpawnPlus;

        // Start is called before the first frame update
        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = listPrefab.Count;

            RespawnObj();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CheckForRespawn()
        {
            if(createdObjects.Count<=0)
            {
                RespawnObj();
            }
        }

        public void RespawnObj()
        {
            randomValueSpawnPlus = 0;
            for (int i = 0; i < listPrefab.Count; i++)
            {
                var obj = Instantiate(listPrefab[i], new Vector3(transform.position.x, transform.position.y + randomValueSpawnPlus, transform.position.z), Quaternion.identity);
                createdObjects.Add(obj);

                randomValueSpawnPlus += Random.Range(4, 7);
            }
        }
    }
}
