using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class InputJson
{
    public Scene[] scene;
}

[Serializable]
public class Scene
{
    public int page;
    public int line;
    public string text;
}

public class JsonTextReader : MonoBehaviour
{
    
    private void Start()
    {
        string inputString = Resources.Load<TextAsset>("Texts/game_text2").ToString();
        InputJson inputJson = JsonUtility.FromJson<InputJson>(inputString);
        Debug.Log(inputJson.scene[0].text);
        Debug.Log(inputJson.scene[1].text);
    }

    private void Update()
    {
        
    }
}
