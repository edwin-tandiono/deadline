﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitToDesktopButton : MonoBehaviour {

	public CanvasGroup mainMenu;
	public CanvasGroup levelSelection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void exitToDestop() {
		Application.Quit();
	}

	public void DoMainMenu() {
		levelSelection.interactable = false;
		levelSelection.alpha = 0;
		mainMenu.interactable = true;
		mainMenu.alpha = 1;
	}

	public void DoLevelSelectionMenu() {
		mainMenu.interactable = false;
		mainMenu.alpha = 0;
		levelSelection.interactable = true;
		levelSelection.alpha = 1;
	}

	public void StartGame(string sceneName) {
		SceneManager.LoadScene ("prototype-map");
	}

}
