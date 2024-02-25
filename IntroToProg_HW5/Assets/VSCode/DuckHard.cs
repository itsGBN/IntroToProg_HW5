using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Duck.Model;

namespace Duck.Hard
{
    public class DuckHard : DuckBase
    {
        // Start is called before the first frame update
        protected override void Start()
        {
            duckSpeed = 15;
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
            duckRenderer.color = new Color(0.7484276f, 0.09913819f, 0f);
        }

        //Method to change the ducks health
        public override void Shot()
        {
            print("1 Damage");
            duckHP -= 1;
        }
    }
}
