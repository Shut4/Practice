using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private TextMeshProUGUI answerText1, answerText2, answerText3, answerText4;

    public static string[,] questionArray = new string[5, 6] {
        {"right", "left", "down", "right", "up", "right"},
        {"up", "left", "down", "right", "up", "up"},
        {"left", "left", "down", "right", "up", "left"},
        {"down", "left", "down", "right", "up", "down"},
        {"up", "left", "down", "right", "up", "up"}
    };

    public static int currentQuestion = 0;

    [SerializeField]
    private GameObject MaruBatsu1, MaruBatsu2, MaruBatsu3, MaruBatsu4, Next;

    [SerializeField]
    private Button answerBtn1, answerBtn2, answerBtn3, answerBtn4;


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

        answerBtn1.interactable = true;
        answerBtn2.interactable = true;
        answerBtn3.interactable = true;
        answerBtn4.interactable = true;
        MaruBatsu1.SetActive(false);
        MaruBatsu2.SetActive(false);
        MaruBatsu3.SetActive(false);
        MaruBatsu4.SetActive(false);
        Next.SetActive(false);
    }
}
