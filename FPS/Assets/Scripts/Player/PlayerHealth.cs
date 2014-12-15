using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

		public int startingHealth = 100;
		public int currentHealth;
		public Slider healthSlider;
		public Image damageImage;
		public float flashSpeed = 5f;
		public Color flashColor = new Color (1f, 0f, 0f, 0.1f);
		public static int health;
		bool damaged;
		Text display;

		// Use this for initialization
		void Awake ()
		{
				currentHealth = startingHealth;
		}
	
		// Update is called once per frame
		void Update ()
		{
				health = currentHealth;
				//If user presses R, then respawn user to the original position
				if (damaged) {
						// ... set the colour of the damageImage to the flash colour.
						damageImage.color = flashColor;
				}
		// Otherwise...
		else {
						// ... transition the colour back to clear.
						damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
				}
		
				// Reset the damaged flag.
				damaged = false;
		}

		public void TakeDamage (int amount)
		{
				damaged = true;

				if (currentHealth > 0) {
						currentHealth -= amount;
						healthSlider.value = currentHealth;
				} else if (currentHealth <= 0) {
						healthSlider.value = 0;
				}
		}

		public void GameOver ()
		{

		
				Application.LoadLevel (3);
		}
}
