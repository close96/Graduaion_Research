using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : BaseButtonController
{
    
    protected override void OnClick(string objectName)
    {
        // 渡されたオブジェクト名で処理を分岐
        if ("YesButton".Equals(objectName))
        {
            this.ButtonClick("Yes");
        } 
        else if ("NoButton".Equals(objectName))
        {
            this.ButtonClick("No");
        }
        else if ("ScreenButton".Equals(objectName))
        {
            this.ButtonClick("Screen");
        }
        else
        {
            throw new System.Exception("Not implemented!!");
        }
    }

    private void ButtonClick(string _clickButton)
    {
        switch (_clickButton)
        {
                case "Yes":
                    Debug.Log("はい");
                    break;
                
                case "No":
                    Debug.Log("いいえ");
                    break;
                
                case "Screen":
                    Debug.Log("画面をクリックしました");
                    UIManager.Instance.HasTouchScreen = true;
                    break;
        }
    }
    
}
