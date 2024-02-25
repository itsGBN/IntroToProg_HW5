using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Duck.Model;

namespace Duck.Normal
{
    public class DuckNormal : DuckBase
    {
        // Start is called before the first frame update
        protected override void Start()
        {
            duckSpeed = 10;
            base.Start();
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }

        //Method to change the Ducks Color
        protected override void Color()
        {
            duckRenderer.color = new Color(1f, 0.4765893f, 0f);
        }

        //Method to change the ducks health
        public override void Shot()
        {
            print("2 Damage");
            duckHP -= 2;
        }
    }
}
