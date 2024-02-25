using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base Features of the Ducks
namespace Duck.Model 
{
    public class DuckBase : MonoBehaviour
    {
        //Duck Properties
        protected int duckSpeed = 5;
        protected int duckHP = 3;
        protected int duckDirectionDecider;

        protected string duckColor;
        protected SpriteRenderer duckRenderer;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            //Initial components
            duckRenderer = GetComponent<SpriteRenderer>();

            //Where does the start from, Left of Right?
            duckDirectionDecider = Random.Range(0, 2);
            Vector3 direction = duckDirectionDecider == 0 ? new Vector3(-55, 20, 40) : new Vector3(55, 5, 40);
            duckSpeed = duckDirectionDecider == 0 ? duckSpeed : duckSpeed * -1;
            this.transform.position = direction;

            //ColorChange
            Color();
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            //Move The Duck by its speed
            transform.position += new Vector3(duckSpeed * Time.deltaTime, 0, 0);

            if(duckHP <= 0)
            {
                Destroy(gameObject);
            }
        }

        //Method to change the Ducks Color
        protected virtual void Color() 
        {
            duckRenderer.color = new Color(1, 1, 1);
        }

        //Print how much damage it did
        public virtual void Shot()
        {
            print("1 Damage");
        }
    }
}

