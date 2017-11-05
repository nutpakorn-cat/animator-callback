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
using UnityEngine;
using System.Collection;
public class CallbackIdx : MonoBehavior {
	/*
	* Variable References
	* 	- idxName : String
	*	 			determine an animation name.
	*		- idxLayer : Short integer
	*				determine an animator layer.
	*/
	public string idxName { get; set; };
	public short idxLayer { get; set; };

	/*
	* Interface Methods
	*		- callbackCondition : bool
	*				determine conditions for running a callback script.
	*		- callbackFunction : void
	*				determine the function that will run when callbackCondition return TRUE value.
	*/
	bool callbackCondition() { return true; }
	void callbackFuntion() { }

	/*
	* Abstract Method
	*		- run : void
	*				run callback script.
	*/
	void run()
	{
			if(callbackCondition())
			{
				// Occurs when callbackCondition return true value.
				callbackFunction();
			}
	}
}
