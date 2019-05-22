using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TextReader : MonoBehaviour
{
    private TextAsset textFile;
    [SerializeField]
    private Text textAppear;

    private void Start()
    {
        textFile = Resources.Load("不思議の国のアリス(一部)") as TextAsset;

        textAppear.text = textFile.text;
    }

}
