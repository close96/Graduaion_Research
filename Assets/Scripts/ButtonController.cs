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
            this.YesButtonClick();
        } 
        else if ("NoButton".Equals(objectName))
        {
            this.NoButtonClick();
        }
        else
        {
            throw new System.Exception("Not implemented!!");
        }
    }

    private void YesButtonClick()
    {
        Debug.Log("はい");
    }

    private void NoButtonClick()
    {
        Debug.Log("いいえ");
    }
    
}
