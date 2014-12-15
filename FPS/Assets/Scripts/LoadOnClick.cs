using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	//public GameObject loadingImage;
	
	public void LoadScene(int level)
	{
		ScoreManager.score = 0;
		TimerManager.timer = 0f;
		//loadingImage.SetActive(true);
		if (level == 1) {
			Screen.showCursor = false;
		}
		Application.LoadLevel(level);

	}
}
