using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Judge : MonoBehaviour
{
    [SerializeField]
    private GameObject MaruBatsu, Next;

    [SerializeField]
    private TextMeshProUGUI maruBatsuText;

    [SerializeField]
    private Button answerBtn1, answerBtn2, answerBtn3, answerBtn4;

    [SerializeField]
    private TextMeshProUGUI answerText;
    public void AnswerJudge()
    {
        answerText = this.GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log(answerText);
        if (answerText.text == GameManager.questionArray[GameManager.currentQuestion, 5])
        {
            //〇を表示
            maruBatsuText.text = "Correct!";
            maruBatsuText.color = new Color(255.0f, 0.0f, 0.0f, 0.8f);
        }
        else
        {
            //×を表示
            maruBatsuText.text = "False..";
            maruBatsuText.color = new Color(0.0f, 0.0f, 255.0f, 0.8f);
        }

        answerBtn1.interactable = false;
        answerBtn2.interactable = false;
        answerBtn3.interactable = false;
        answerBtn4.interactable = false;

        MaruBatsu.SetActive(true);
        Next.SetActive(true);
    }
}