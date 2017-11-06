using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public class SampleCallback : CallbackCore
    {
        public override void callbackFunction()
        {
            // Coding here. 
        }
        public override void callbackElseFunction()
        {
            // (Optional) When callbackFunction haven't returned TRUE yet.

        }
        public override void callbackLog()
        {
            // (Optional) Called after callbackFunction
        }
    }
}