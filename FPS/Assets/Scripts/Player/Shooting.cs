using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public Transform bulletSpawn;
	public float fireRate;
	public int attackDamage = 5;
	public int ammoCount = 10;
	public Slider ammoSlider;
	public bool empty;

	private float nextFire = 0.0f;

	//Change bullet speed if you think it's too fast/slow
	//Closer to 0 is slower, and vica versa
	private int bulletSpeed = -500;

	//Amount of seconds the bullet will live in the game world
	private float destroyInSeconds = 5f;
	
	// Update is called once per frame
	void Update () 
	{

		//Check if the player fires the gun
		if(Input.GetButtonDown("Fire1") && Time.time > nextFire && ammoCount > 0){
			//Controls how quickly the player can shoot
			nextFire = Time.time + fireRate;

			//Create the bullet in the game world
			GameObject fakeBullet = (GameObject) Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
			ammoCount -= 1;
			ammoSlider.value = ammoCount;
			AmmoManager.ammo -= 1;

			//Move the bullet forward
			fakeBullet.rigidbody.AddForce(bulletSpawn.forward * bulletSpeed);


			//Destroys the bullet
			Destroy(fakeBullet, 5f);
		}

		if (Input.GetButtonDown ("Fire2")) 
		{
			ammoCount = 10;
			ammoSlider.value = ammoCount;
			AmmoManager.ammo = 10;
		}
	}

}
