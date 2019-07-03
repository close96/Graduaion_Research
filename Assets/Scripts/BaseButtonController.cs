using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseButtonController : UIManager {
    
    public BaseButtonController button;

    public void OnClick()
    {
        if (button == null)
        {
            throw new System.Exception("Button instance is null!!");
        }
        button.OnClick(this.gameObject.name);
    }

    protected virtual void OnClick(string objectName)
    {
        // 呼ばれることはない
        Debug.Log("Base Button");
    }
    
}
