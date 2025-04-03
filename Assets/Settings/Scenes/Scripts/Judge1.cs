using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Judge1 : MonoBehaviour
{
    public TextMeshProUGUI maruBatsuText;
    private GameManager1 gamemanager1;
    public TextMeshProUGUI answerText;

    private Portal portalComponent;

    public void nextquestion()
    {
        gamemanager1 = FindObjectOfType<GameManager1>();

        if (gamemanager1 != null)
        {
            gamemanager1.NextQuestion();
        }
    }


    // public void Assignportal()
    // {
    //     portalComponent = GetComponent<Portal>();
    //     portalComponent.OnTriggerEnter2D(Collider2D collision);
    // }

    public void AnswerJudge()
    {
        if (answerText.text == GameManager.csvQuestionDataShuffl[GameManager.currentQuestion].correctAnswer)
        {
            // Debug.Log("ok");
            nextquestion();
            // Assignportal();
        }
        else
        {
            // Debug.Log("a");
            maruBatsuText.text = "False..";
            maruBatsuText.color = new Color(0.0f, 0.0f, 255.0f, 0.8f);
            GameManager1.MaruBatsu1.SetActive(true);
            GameManager1.MaruBatsu2.SetActive(true);
            GameManager1.MaruBatsu3.SetActive(true);
            GameManager1.MaruBatsu4.SetActive(true);
            // nextquestion();
        }
    }

}