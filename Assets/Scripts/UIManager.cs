using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
	public bool HasTouchScreen
	{
		get { return hasTouchScreen; }
		set { hasTouchScreen = value; }
	}

	private bool hasTouchScreen;

	[SerializeField]
	private GameObject titleCanvas;
	
	void Start ()
	{
		DontDestroyOnLoad(this);
	}
	
	void Update ()
	{
		// タイトル画面をクリックでゲームシーンに移行
		if (GameManager.Instance.CurrentGameState == GameManager.GameState.Title && hasTouchScreen)
		{
			titleCanvas.SetActive(false);
			GameManager.Instance.HasChangeState = true;
			GameManager.Instance.NextGameState = GameManager.GameState.GameScene;
			hasTouchScreen = false;
		}
	}
	
}
