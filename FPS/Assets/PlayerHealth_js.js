#pragma strict

import UnityEngine;
import UnityEngine.UI;
import System.Collections;

public var startingHealth = 100;
public var currentHealth: int;
public var healthSlider: Slider;
private var damaged: boolean;

function Start () {
	currentHealth = startingHealth;
}

function Update () {

}

function TakeDamage (amount: int){
	damaged = true;
	
	if(currentHealth > 0){
		currentHealth -= amount;
		healthSlider.value = currentHealth;
	} else if (currentHealth <= 0){
		healthSlider.value = 0;
	}
}