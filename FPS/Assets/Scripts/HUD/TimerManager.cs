using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerManager : MonoBehaviour
{
		public static float timer;        // The player's score.


		Text text;                      // Reference to the Text component.

	
		void Awake ()
		{
				// Set up the reference.
				text = gameObject.GetComponent <Text> ();
				// Reset the score.
				timer = 0f;
		}
	
		void Update ()
		{
				if (PlayerHealth.health > 0) {
						// Set the displayed text to be the word "Score" followed by the score value.
						timer += Time.deltaTime;			
						text.text = "Time Survived " + timer;
				}
		}
}