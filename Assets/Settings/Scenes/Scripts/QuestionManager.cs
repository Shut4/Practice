using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText, answerText1, answerText2, answerText3, answerText4;
    // [SerializeField]
    // private Button answerBtn1, answerBtn2, answerBtn3, answerBtn4;
    [SerializeField]
    private GameObject MaruBatsu1, MaruBatsu2, MaruBatsu3, MaruBatsu4;// Next;
    public void NextQuestion()
    {
        GameManager.currentQuestion++;
        questionText.text = GameManager.csvQuestionDataShuffl[GameManager.currentQuestion].question;
        answerText1.text = GameManager.csvQuestionDataShuffl[GameManager.currentQuestion].answer1;
        answerText2.text = GameManager.csvQuestionDataShuffl[GameManager.currentQuestion].answer2;
        answerText3.text = GameManager.csvQuestionDataShuffl[GameManager.currentQuestion].answer3;
        answerText4.text = GameManager.csvQuestionDataShuffl[GameManager.currentQuestion].answer4;

        // answerBtn1.interactable = true;
        // answerBtn2.interactable = true;
        // answerBtn3.interactable = true;
        // answerBtn4.interactable = true;
        MaruBatsu1.SetActive(false);
        MaruBatsu2.SetActive(false);
        MaruBatsu3.SetActive(false);
        MaruBatsu4.SetActive(false);
        // Next.SetActive(false);
    }
}
