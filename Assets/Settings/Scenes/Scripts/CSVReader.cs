using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    //　流し込む配列
    public CSVQuestionData[] csvQuestionData;

    void Start()
    {
        //　テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        //　先ほど用意したcsvファイルを読み込ませる。
        //　ファイルは「Resources」フォルダを作り、そこに入れておくこと。また"CSVTestData"の部分はファイル名に合わせて変更する。
        textasset = Resources.Load("CSV/CSVQuestionData", typeof(TextAsset)) as TextAsset;
        //　CSVSerializerを用いてcsvファイルを配列に流し込む。
        csvQuestionData = CSVSerializer.Deserialize<CSVQuestionData>(textasset.text);
        // Debug.Log(textasset);
    }

}
