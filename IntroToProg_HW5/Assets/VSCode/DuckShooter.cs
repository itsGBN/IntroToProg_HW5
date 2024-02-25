using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Duck.Model;
using Duck.Easy;
using Duck.Normal;
using Duck.Hard;
using Duck.GameManager;
using Duck.Gun;

namespace Duck.Gun
{
    //Shooting the Gun
    public class DuckShooter : MonoBehaviour
    {
        //Gameobjects
        DuckEasy duckEasy;
        DuckNormal duckNormal;
        DuckHard duckHard;


        // Update is called once per frame
        void Update()
        {
            //Create an array when clicking the mouse
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red, 1f);

                //If the array hits an object, check which duck it is and call the method
                if (Physics.Raycast(ray, out hit, 1000))
                {
                    //call the method of the easy duck
                    if (hit.collider.gameObject.tag == "DuckEasy")
                    {
                        duckEasy = hit.collider.gameObject.GetComponent<DuckEasy>();
                        duckEasy.Shot();
                    }
                    //call the method of the normal duck
                    if (hit.collider.gameObject.tag == "DuckNormal")
                    {
                        duckNormal = hit.collider.gameObject.GetComponent<DuckNormal>();
                        duckNormal.Shot();
                    }
                    //call the method of the hard duck
                    if (hit.collider.gameObject.tag == "DuckHard")
                    {
                        duckHard = hit.collider.gameObject.GetComponent<DuckHard>();
                        duckHard.Shot();
                    }
                }
            }
        }
    }
}

