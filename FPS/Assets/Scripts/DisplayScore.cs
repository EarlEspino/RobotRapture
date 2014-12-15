using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayScore : MonoBehaviour {

	Text txt;
	int highScore = ScoreManager.highScore;
	int score = ScoreManager.score;

	public static int currentscore;

	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text> ();
		if (score > highScore) {
						ScoreManager.highScore = score;
						txt.text = "Score: " + ScoreManager.score + "\n" +
								"Time Survived: " + TimerManager.timer + "\n" +
								"Current High Score: " + score;
				} else {
						txt.text = "Score: " + ScoreManager.score + "\n" +
								"Time Survived: " + TimerManager.timer + "\n" +
								"Current High Score: " + highScore;
				}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
