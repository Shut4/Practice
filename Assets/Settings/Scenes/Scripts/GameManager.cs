using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private TextMeshProUGUI answerText1, answerText2, answerText3, answerText4;

    public static string[,] questionArray = new string[2, 6] {
        {"右", "左", "下", "右", "上", "右"},
        {"上", "左", "下", "右", "上", "上"}
    };

    public static int currentQuestion = 0;


    // Start is called before the first frame update
    void Start()
    {
        questionText.text = questionArray[currentQuestion, 0];
        answerText1.text = questionArray[currentQuestion, 1];
        answerText2.text = questionArray[currentQuestion, 2];
        answerText3.text = questionArray[currentQuestion, 3];
        answerText4.text = questionArray[currentQuestion, 4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextQuestion()
    {
        currentQuestion++;
        questionText.text = questionArray[currentQuestion, 0];
        answerText1.text = questionArray[currentQuestion, 1];
        answerText2.text = questionArray[currentQuestion, 2];
        answerText3.text = questionArray[currentQuestion, 3];
        answerText4.text = questionArray[currentQuestion, 4];
    }
}
