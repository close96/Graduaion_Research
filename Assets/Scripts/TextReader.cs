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

    private void Start()
    {
        csvFile = Resources.Load("csv読み込みテスト") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            textDatas.Add(line.Split(','));
        }

        textAppear.text = textDatas[0][0];
    }

}
