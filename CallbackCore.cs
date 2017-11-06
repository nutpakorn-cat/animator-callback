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
