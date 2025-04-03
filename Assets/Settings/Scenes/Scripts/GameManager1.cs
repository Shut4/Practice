using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText, answerText1, answerText2, answerText3, answerText4;
    CSVQuestionData[] csvQuestionData;
    public static CSVQuestionData[] csvQuestionDataShuffl;
    public static int currentQuestion = 0;
    public TextMeshProUGUI maruBatsuText;

    public static GameObject MaruBatsu1, MaruBatsu2, MaruBatsu3, MaruBatsu4;//, Next;
    // [SerializeField]
    // private Button answerBtn1, answerBtn2, answerBtn3, answerBtn4;
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

        // answerBtn1.onClick.AddListener(OnTriggerEnter2D_1);
        // answerBtn2.onClick.AddListener(OnTriggerEnter2D_2);
        // answerBtn3.onClick.AddListener(OnTriggerEnter2D_3);
        // answerBtn4.onClick.AddListener(OnTriggerEnter2D_4);
    }
    public void NextQuestion()
    {
        currentQuestion++;
        questionText.text = csvQuestionDataShuffl[currentQuestion].question;
        answerText1.text = csvQuestionDataShuffl[currentQuestion].answer1;
        answerText2.text = csvQuestionDataShuffl[currentQuestion].answer2;
        answerText3.text = csvQuestionDataShuffl[currentQuestion].answer3;
        answerText4.text = csvQuestionDataShuffl[currentQuestion].answer4;
        MaruBatsu1.SetActive(false);
        MaruBatsu2.SetActive(false);
        MaruBatsu3.SetActive(false);
        MaruBatsu4.SetActive(false);
    }
}
