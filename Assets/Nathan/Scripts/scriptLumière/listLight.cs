using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class listLight : MonoBehaviour
    {
        public List<GameObject> lights;

        public float randomRotateSpawn;
        private LevelManager lm;
        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            for (int i = 0; i < 4; i++)
            {
                var currentObj = lights[i].gameObject;
                if (i == 0)
                {
                    randomRotateSpawn = Random.Range(-45, 10);
                    currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                }
                if (i == 1)
                {
                    float leftOrRight;
                    leftOrRight = Random.Range(0f, 1f);

                    if (leftOrRight < 0.5)
                    {
                        randomRotateSpawn = Random.Range(-45, -10);
                        currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                    }
                    else
                    {
                        randomRotateSpawn = Random.Range(45, 10);
                        currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                    }
                }
                if (i == 2)
                {
                    randomRotateSpawn = Random.Range(-10, 45);
                    currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                }
            }

            lm.scoreSceneNeed = 3;
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
