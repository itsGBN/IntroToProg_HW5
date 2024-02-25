using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Duck.GameManager
{
    //Spawn the ducks
    public class DuckSpawner : MonoBehaviour
    {
        //GameObjects
        [SerializeField] GameObject DuckEasy;
        [SerializeField] GameObject DuckNormal;
        [SerializeField] GameObject DuckHard;

        // Start is called before the first frame update
        void Start()
        {
            //Spawn a duck every 1-2 Seconds
            InvokeRepeating("Spawn", 2, Random.Range(0, 2));
        }


        void Spawn()
        {
            //Chose a random number between 1-2
            int duckLevel = Random.Range(0, 3);
            switch (duckLevel)
            {
                //If 0, spawn an easyduck
                case 0:
                    Instantiate(DuckEasy);
                    break;
                //if 1, spawn a normalduck
                case 1:
                    Instantiate(DuckNormal);
                    break;
                //if 2, spawn a hardduck
                case 2:
                    Instantiate(DuckHard);
                    break;
            }
        }
    }
}

