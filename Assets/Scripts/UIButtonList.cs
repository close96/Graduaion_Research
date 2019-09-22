using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIButtonList : MonoBehaviour
{
    [System.Serializable]
    private class Pair
    {
        public string key;
        public Button btn;

        public Pair(Button btn)
        {
            key = "";
            this.btn = btn;
        }
    }

    [SerializeField]
    private List<Pair> m_pair;

    public UnityAction<string> onClick
    {
        get; set; 
    }

    void Awake()
    {
        // キーが引数になるクリックイベントを登録
        foreach (Pair pair in m_pair)
        {
            Button btn = pair.btn;
            if (btn == null)
            {
                continue;
            }
            btn.onClick.AddListener(() => OnClick(pair.key));
        }

        // 動作確認用
        onClick = OnClick_Log;
    }

    private void Setup()
    {
        // 子供にいるボタンを列挙
        Button[] btnList = transform.GetComponentsInChildren<Button>();
        
        if(m_pair == null) { m_pair = new List<Pair>(); }

        foreach (Button btn in btnList)
        {
            if (m_pair.FindIndex(x => x.btn == btn) < 0)
            {
                m_pair.Add(new Pair(btn));
            }
        }
        
        // ボタンが無くなっていたらリストから削除
        for (int i = m_pair.Count - 1; i >= 0; i--)
        {
            if (m_pair[i].btn == null)
            {
                m_pair.RemoveAt(i);
            }
        }
    }

    public Button Get(string key)
    {
        // キーで取得
        Pair pair = m_pair.Find(x => x.key == key);
        if (pair == null)
        {
            return null; 
        }
        return pair.btn;
    }

    private void OnClick(string key)
    {
        if (onClick == null)
        {
            return;
        }
        onClick(key);
    }

    private void OnClick_Log(string key)
    {
        Debug.Log(key);
    }
    
    #if UNITY_EDITOR
    [CustomEditor(typeof(UIButtonList))]
    public class UIButtonListEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            UIButtonList btnList = target as UIButtonList;
            if(GUILayout.Button("Setup"))
            {
                btnList.Setup();
            }

            base.OnInspectorGUI();
        }
    }
    #endif
}
