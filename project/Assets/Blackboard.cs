﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackboard : MonoBehaviour {

	public Leap.Unity.Interaction.InteractionSlider slider;

	bool isProximity = false;
	bool isFinger = false;

	void Start (){
		slider.manager = Leap.Unity.Interaction.InteractionManager.instance;
	}
	
	public void proximityEnter() {
		print("proximity");
		isProximity = true;
	}

	public void proximityExit() {
		print("end proximity");
		isProximity = false;
	}

	public void fingerEnter() {
		print("finger");
		isFinger = true;
	}

	public void fingerExit() {
		print("end finger");
		isFinger = false;
	}

	void Update() {


		if(isFinger && isProximity) {
			print("DRAWING");
		} 

	}
	
}
