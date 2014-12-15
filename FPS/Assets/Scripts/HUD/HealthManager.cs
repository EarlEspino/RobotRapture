using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static int health;
	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent <Text> ();

		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		//health = PlayerHealth.currentHealth;
		text.text = "" + health;
	}
}
