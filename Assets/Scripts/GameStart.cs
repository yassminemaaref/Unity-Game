﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator gameStart(){
		yield return new WaitForSeconds (.1f);
		SceneManager.LoadScene ("Game");
		gameObject.SetActive(false);
	}
}
