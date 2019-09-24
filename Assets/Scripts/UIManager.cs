using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : SingletonMonoBehaviour<UIManager>
{

	public UIButtonList btnList;
	
	void Start ()
	{
		DontDestroyOnLoad(this);
		btnList.onClick = OnClick;
	}

	private void OnClick(string _key)
	{
		switch (_key)
		{
			case "Yes":
				Debug.Log("はいを押したよ");
				break;
			// タイトル画面をクリック。ゲーム画面に移行
			case "TitleScreen":
				GameManager.Instance.SceneChange(GameManager.GameState.GameScene);
				break;
		}
	}
	
}
