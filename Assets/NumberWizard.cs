using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int guess;
	int maxGuessesAllowed;
	
	public Text text;

	// Use this for initialization
	void Start () {
		min = 1;
		max = 1000;
		maxGuessesAllowed = 8;
		
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess = Random.Range(min, max+1);
		maxGuessesAllowed--;
		
		text.text = "Is your number " + guess + "?";
		
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
	
}
