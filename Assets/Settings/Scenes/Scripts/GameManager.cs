using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText, answerText1, answerText2, answerText3, answerText4;
    /*
    public static string[,] questionArray = new string[5, 6] {
        {"right", "left", "down", "right", "up", "right"},
        {"up", "left", "down", "right", "up", "up"},
        {"left", "left", "down", "right", "up", "left"},
        {"down", "left", "down", "right", "up", "down"},
        {"up", "left", "down", "right", "up", "up"}
    };
    */
    CSVQuestionData[] csvQuestionData;
    public static CSVQuestionData[] csvQuestionDataShuffl;
    public static int currentQuestion = 0;

    // Start is called before the first frame update
    void Start()
    {
        //　テキストファイルの読み込みを行ってくれるクラス
        TextAsset textasset = new TextAsset();
        //　先ほど用意したcsvファイルを読み込ませる。
        //　ファイルは「Resources」フォルダを作り、そこに入れておくこと。また"CSVTestData"の部分はファイル名に合わせて変更する。
        textasset = Resources.Load("CSV/CSVQuestionData", typeof(TextAsset)) as TextAsset;
        //　CSVSerializerを用いてcsvファイルを配列に流し込む。
        csvQuestionData = CSVSerializer.Deserialize<CSVQuestionData>(textasset.text);
        csvQuestionDataShuffl = csvQuestionData.OrderBy(i => Guid.NewGuid()).ToArray();
        // Debug.Log(csvQuestionData[1].answer1);

        questionText.text = csvQuestionDataShuffl[currentQuestion].question;
        answerText1.text = csvQuestionDataShuffl[currentQuestion].answer1;
        answerText2.text = csvQuestionDataShuffl[currentQuestion].answer2;
        answerText3.text = csvQuestionDataShuffl[currentQuestion].answer3;
        answerText4.text = csvQuestionDataShuffl[currentQuestion].answer4;

        /*
        questionText.text = questionArray[currentQuestion, 0];
        answerText1.text = questionArray[currentQuestion, 1];
        answerText2.text = questionArray[currentQuestion, 2];
        answerText3.text = questionArray[currentQuestion, 3];
        answerText4.text = questionArray[currentQuestion, 4];
        */
    }
}
