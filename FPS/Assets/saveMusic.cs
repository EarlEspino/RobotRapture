using UnityEngine;
using System.Collections;

public class saveMusic : MonoBehaviour {

	public GameObject music;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (music);
	}

}
