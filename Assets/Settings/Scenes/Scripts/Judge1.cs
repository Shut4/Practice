using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Judge1 : MonoBehaviour
{
    public TextMeshProUGUI answerText;
    public TextMeshProUGUI GameOver_Text;
    private GameManager1 gamemanager1;
    // private Coroutine coroutine;
    private Portal portal;
    private dinosaur_move _dinoMove;
    public TextMeshProUGUI maruBatsuText;
    public AudioSource audioSource;
    public GameObject gameover_button;

    private void Start()
    {
        gamemanager1 = FindObjectOfType<GameManager1>();
        // coroutine = GetComponent<Coroutine>();
        portal = FindObjectOfType<Portal>();
        _dinoMove = FindObjectOfType<dinosaur_move>();
        GameOver_Text.gameObject.SetActive(false);
    }
    public void AnswerJudge()
    {
        // Debug.Log(GameManager1.csvQuestionDataShuffl[GameManager1.currentQuestion].correctAnswer.ToString());
        // Debug.Log(answerText.text);
        if (answerText.text == GameManager1.csvQuestionDataShuffl[GameManager1.currentQuestion].correctAnswer.ToString())
        {
            // Debug.Log(answerText.text);
            gamemanager1.NextQuestion();
            portal.TriggerTeleport(GetComponent<Collider2D>());
        }
        else
        {
            // maruBatsuText.text = "False..";
            // maruBatsuText.color = new Color(0.0f, 0.0f, 255.0f, 0.8f);
            // SoundManager.Instance.StopBGM(BGMSoundData.BGM.Title);
            // SoundManager.Instance.PlaySE(SESoundData.SE.Hoge);
            // gamemanager1.MaruBatsu1.SetActive(true);
            // gamemanager1.MaruBatsu2.SetActive(true);
            // gamemanager1.MaruBatsu3.SetActive(true);
            // gamemanager1.MaruBatsu4.SetActive(true);
            // coroutine.Test();
            // portal.TriggerTeleport(GetComponent<Collider2D>());
            // gamemanager1.MaruBatsu1.SetActive(false);
            // gamemanager1.MaruBatsu2.SetActive(false);
            // gamemanager1.MaruBatsu3.SetActive(false);
            // gamemanager1.MaruBatsu4.SetActive(false);
            // gamemanager1.NextQuestion();
            // _dinoMove._animator.SetTrigger("YourTriggerName");
            _dinoMove._animator.SetFloat("X", 0);
            _dinoMove._animator.SetFloat("Y", -1);
            Debug.Log("a");
            GameOver_Text.gameObject.SetActive(true);
            gameover_button.SetActive(true);
            Time.timeScale = 0;
        }
    }
}