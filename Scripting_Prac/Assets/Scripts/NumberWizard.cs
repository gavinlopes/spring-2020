using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	
	int max = 1000;
	int min = 1;
	int guess = 500;
	

	// Use this for initialization
	void Start ()
	{
		Debug.Log("Welcome to number wizard people");
		Debug.Log("Welcome");
		Debug.Log("Pick a number");
		Debug.Log("Highest number is: " + max);
		Debug.Log("Lowest number is: " + min);
		Debug.Log("Tell me if your number is higher or lower than 500");
		Debug.Log("Push up = Higher, Push down = Lower, Push enter if correct");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Up Arrow key was pressed.");
			min = guess;
			Debug.Log(guess);
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Debug.Log("Down Arrow key was pressed.");
			max = guess;
			Debug.Log(guess);

		}

		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("Return key was pressed");
		}
	}
}
