using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Judge1 : MonoBehaviour
{
    public TextMeshProUGUI answerText;
    private GameManager1 gamemanager1;
    // private Coroutine coroutine;
    private Portal portal;
    public TextMeshProUGUI maruBatsuText;

    private void Start()
    {
        gamemanager1 = FindObjectOfType<GameManager1>();
        // coroutine = GetComponent<Coroutine>();
        portal = FindObjectOfType<Portal>();
    }
    public void AnswerJudge()
    {
        if (answerText.text == GameManager1.csvQuestionDataShuffl[GameManager1.currentQuestion].correctAnswer)
        {
            // Debug.Log(answerText);
            gamemanager1.NextQuestion();
            portal.TriggerTeleport(GetComponent<Collider2D>());
        }
        else
        {
            maruBatsuText.text = "False..";
            maruBatsuText.color = new Color(0.0f, 0.0f, 255.0f, 0.8f);
            gamemanager1.MaruBatsu1.SetActive(true);
            gamemanager1.MaruBatsu2.SetActive(true);
            gamemanager1.MaruBatsu3.SetActive(true);
            gamemanager1.MaruBatsu4.SetActive(true);
            // coroutine.Test();
            portal.TriggerTeleport(GetComponent<Collider2D>());
            // gamemanager1.MaruBatsu1.SetActive(false);
            // gamemanager1.MaruBatsu2.SetActive(false);
            // gamemanager1.MaruBatsu3.SetActive(false);
            // gamemanager1.MaruBatsu4.SetActive(false);
            gamemanager1.NextQuestion();
        }
    }
}