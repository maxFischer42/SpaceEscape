﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlockGun : MonoBehaviour {

	public Text textObj;
	public Behaviour behaviourToActivate;
	public GameObject gameObjectToActivate;
	public string textToDisplay;

	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "Player") {
			textObj.enabled = true;
			textObj.text = textToDisplay;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if (coll.gameObject.tag == "Player") {
			textObj.enabled = false;
			textObj.text = " ";
		}
	}


	void OnTriggerStay(Collider coll)
	{
		if (coll.gameObject.tag == "Player" && Input.GetButtonDown("Interact"))
		{

			textObj.enabled = false;
			textObj.text = " ";

			if(behaviourToActivate != null)
				behaviourToActivate.enabled = true;
			
			if (gameObjectToActivate != null)
				gameObjectToActivate.SetActive (true);

			Destroy (transform.parent.gameObject);
		}
	}


}