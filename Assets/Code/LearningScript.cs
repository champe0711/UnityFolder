using UnityEngine;
using System.Collections.Generic;

public class LearningScript : MonoBehaviour {
	int num1 = 2;
	int num2 = 3;
	int num3 = 7;
	
	// Use this for initialization
	void Start () {

		List<string> myFavoritePonies = new List<string> ();
		myFavoritePonies.Add ("Adam");
		myFavoritePonies.Add ("Becca");
		myFavoritePonies.Add ("Cristy");
		myFavoritePonies.Add ("Denise");

		Debug.Log ("This List has " + myFavoritePonies.Count + " ponies.");

		Debug.Log ("The Pony's name at index 1 is " + myFavoritePonies [1]);
		Debug.Log ("The Pony's name at index 2 is " + myFavoritePonies [2]);
		Debug.Log ("The Pony's name at index 3 is " + myFavoritePonies [3]);

		bool theBearMadeBigPottyInTheWoods = false;

		if (theBearMadeBigPottyInTheWoods) 
		{
			Debug.Log("This is true, and it's stinky, too.");
		} else {
			Debug.Log("Of course NOT, it's a polar bear.");
		}


		int ans = AddTwoNumber (num1, num2) + AddTwoNumber (num1, num3);
		displayResult (ans);

	}
	
	// Update is called once per frame
	void Update () {
	}

	int AddTwoNumber(int firstNumber, int secondNumber)
	{
		return firstNumber + secondNumber;
	}

	void displayResult(int total)
	{
		Debug.Log ("The grand total is : " + total);
	}



}
