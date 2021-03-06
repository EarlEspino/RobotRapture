﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
		public static int score;        // The player's score.
	public static int highScore;
	public static int currentScore;
		Text text;                      // Reference to the Text component.
	
	
		void Awake ()
		{
				// Set up the reference.
				text = gameObject.GetComponent <Text> ();
				// Reset the score.
				score = 0;

		if (highScore > 0) {
						highScore = highScore;
				} else {
						highScore = 0;
				}
		}
	
	
		void Update ()
		{
			if (PlayerHealth.health > 0) {
						// Set the displayed text to be the word "Score" followed by the score value.
						text.text = "Score " + score;
				}

		}
}