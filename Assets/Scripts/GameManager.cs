using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMonoBehaviour<GameManager> 
{
	public enum GameState
	{
		Title,
		GameScene,
	}

	public GameState CurrentGameState
	{
		get { return currentGameState; }
		set { currentGameState = value; }
	}
	public bool HasChangeState
	{
		get { return hasChangeState; }
		set { hasChangeState = value; }
	}

	public GameState NextGameState
	{
		get { return nextGameState; }
		set { nextGameState = value; }
	}

	private GameState currentGameState;
	private bool hasChangeState;
	private GameState nextGameState;

	void Start ()
	{
		DontDestroyOnLoad(this);
		CurrentGameState = GameState.Title;
	}
	
	void Update ()
	{
		if (hasChangeState)
		{
			currentGameState = nextGameState;
			SceneManager.LoadScene(currentGameState.ToString());
			hasChangeState = false;
		}
	}

}
