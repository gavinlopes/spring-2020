using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start ()
	{
		StartGame();	
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;
		
		Debug.Log("Yo watch me pick your number!");
		Debug.Log("How are ya btw?");
		Debug.Log("Go ahead, pick a number");
		Debug.Log("Highest number is: " + max);
		Debug.Log("Lowest number is: " + min);
		Debug.Log("Tell me if your number is higher or lower than: " + guess);
		Debug.Log("Push up = Higher, Push down = Lower, Push enter if correct");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
			
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("TOLD YOU SO!");
			StartGame();
		}
	}

	void NextGuess()
	{
		guess = (max + min) / 2;
		Debug.Log("Is it higher or lower than..." + guess);
	}
}
