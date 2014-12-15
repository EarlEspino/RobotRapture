using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {

	public static int ammo;
	Text text;

	// Use this for initialization
	void Start () {
	
		text = GetComponent <Text> ();

		ammo = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "" + ammo;
	}
}
