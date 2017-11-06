/*
MIT License

Copyright (c) 2017 Nutpakorn Tassanasorn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public abstract class CallbackCore
    {
        /*
	* Variable References
	*  - idxName : String
	*      determine an animation name.
	*  - idxLayer : Short integer
	*      determine an animator layer.
	*/
        public string idxName { get; set; }
        public short idxLayer { get; set; }
        public Animator anim; // GameObject animator.

        // Enable logger function, (recommend to set FALSE for optimizing performance)
        public bool useLog = false;

        /*
	    * Interface Methods
	    *  - callbackFunction : void
	    *	   determine the function that will call when callbackCondition return TRUE value.
	    *  - callbackLog : void
	    *	   determine the logger function that will call when useLog is TRUE.
	    */
        public virtual void callbackFunction() { }
        public virtual void callbackElseFunction() { }
        public virtual void callbackLog() { }

        /*
	* Abstract Method
        *  - callbackCondition : bool
	*      determine conditions for running a callback script.
	*  - run : void
	*      run a callback script.
	*/
        public bool callbackCondition()
        {
            // Callback condition
            if (!anim.GetCurrentAnimatorStateInfo(idxLayer).IsName(idxName))
            {
                return true;
            }
            callbackElseFunction();
            return false;
        }
        public void run()
        {
            if (callbackCondition())
            {
                // Occurs when callbackCondition return TRUE value.
                callbackFunction();
            }
            else if (useLog)
            {
                // Enable logger
                callbackLog();
            }
        }
    }
}
