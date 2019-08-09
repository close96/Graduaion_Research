using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TextReader : MonoBehaviour
{
    private TextAsset csvFile;
    private List<string[]> textDatas = new List<string[]>();
    [SerializeField]
    private Text textAppear;
    private int i = 0;

    private void Start()
    {
        csvFile = Resources.Load("Texts/game_text") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            textDatas.Add(line.Split('、'));
        }

        textAppear.text = textDatas[0][0];
        
       
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            i++;
            textAppear.text = textDatas[i][0];
        }
    }

}
