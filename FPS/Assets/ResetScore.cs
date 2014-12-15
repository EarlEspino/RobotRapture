using UnityEngine;
using System.Collections;

public class ResetScore : MonoBehaviour {

	// Use this for initialization
	public void Reset () {
		ScoreManager.score = 0;
		TimerManager.timer = 0f;
	}
	

}
