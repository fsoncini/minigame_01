﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public int score = 0;
	//public int targetScore = 4;
	public Text scoreText;
	public Text timeText;
	public int timePerLevel = 15;
	public GameObject youWon;
	public GameObject gameOver;


	private float clockSpeed = 1f;


	void Awake () 
	{
		scoreText.text = ("Coin: " + score);// + "/" + targetScore);

		InvokeRepeating("Clock", 0, clockSpeed);
	}

	void Clock()
	{
		timePerLevel--;
		timeText.text = ("Time: " + timePerLevel);
		if (timePerLevel == 0)
		{
			CheckGameOver();
		}
	}

	public void AddPoints(int pointScored)
	{
		score += pointScored;
		scoreText.text = ("Coin: " + score);// + "/" + targetScore);
	}

	void CheckGameOver()
	{
		Time.timeScale = 0;
		gameOver.SetActive(true);
		/*
		if (score >= targetScore)
		{
			Time.timeScale = 0;
			youWon.SetActive(true);
		}
		else
		{
			Time.timeScale = 0;
			gameOver.SetActive(true);
		}
*/
}

}