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

	private GameState currentGameState;

	void Start ()
	{
		DontDestroyOnLoad(this);
		CurrentGameState = GameState.Title;
	}

	public void SceneChange(GameState _currentGameState)
	{
		currentGameState = _currentGameState;
		switch (currentGameState)
		{
			case GameState.GameScene:
				SceneManager.LoadScene("GameScene");
				break;
		}
	}

}
