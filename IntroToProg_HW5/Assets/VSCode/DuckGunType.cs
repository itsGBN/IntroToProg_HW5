using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Duck.GameManager
{
    //Skins for your Gun
    public class DuckGunType : MonoBehaviour
    {
        //Create an Instance for the script for a singeton
        public static DuckGunType instance;

        //Components
        SpriteRenderer gunRenderer;
        public int gunSkin;

        //Sprites Skins
        [SerializeField] Sprite FlameGun;
        [SerializeField] Sprite LoveGun;
        [SerializeField] Sprite WaterGun;

        //Struct
        public struct DuckGunSkin
        {
            //Data Fields
            public string skin;

            //Constructtor
            public DuckGunSkin(string s)
            {
                skin = s;
            }
        }

        //Singelton
        private void Awake()
        {
            //If null, become this instance
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);
            }
            //Else, destroy self
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            //Initialize Componeents
            gunRenderer = gameObject.GetComponent<SpriteRenderer>();
        }
        private void Update()
        {
        //If we are in the game scene
          if(SceneManager.GetActiveScene().name == "SampleScene")
            {
                switch(gunSkin)
                {
                    //Switch skin to fire
                    case 0:
                        DuckGunSkin flameGun = new DuckGunSkin("flameGun");
                        gunRenderer.sprite = FlameGun;
                        gunSkin = 3;
                        break;
                    //switch skin to love
                    case 1:
                        DuckGunSkin loveGun = new DuckGunSkin("loveGun");
                        gunRenderer.sprite = LoveGun;
                        gunSkin = 3;
                        break;
                    //switch ski to water
                    case 2:
                        DuckGunSkin waterGun = new DuckGunSkin("waterGun");
                        gunRenderer.sprite = WaterGun;
                        gunSkin = 3;
                        break;

                }
            }
        }

        //Check whether the the user clicks the flame, gun or love gun
        public void FlameScene() { gunSkin = 0; SceneManager.LoadScene("SampleScene"); }
        public void LoveGunScene() { gunSkin = 1; SceneManager.LoadScene("SampleScene"); }
        public void WaterGunScene() { gunSkin = 2; SceneManager.LoadScene("SampleScene"); }

    }
}
