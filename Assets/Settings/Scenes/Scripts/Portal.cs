using UnityEngine;
public class Portal : MonoBehaviour
{
    [SerializeField] private Transform destination;
    private float distance = 0.3f;
    [SerializeField]
    private Judge1 judge1;
    private GameManager1 gamemanager1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (judge1.answerText.text == GameManager1.csvQuestionDataShuffl[GameManager.currentQuestion].correctAnswer
            && Vector2.Distance(transform.position, collision.transform.position) > distance)
        {
            // Debug.Log(judge1.answerText.text);
            // Debug.Log(GameManager1.csvQuestionDataShuffl[GameManager.currentQuestion].correctAnswer);
            collision.transform.position = new Vector2(destination.position.x, destination.position.y);
            judge1.nextquestion();
        }
        else
        {
            judge1.maruBatsuText.text = "False..";
            judge1.maruBatsuText.color = new Color(0.0f, 0.0f, 255.0f, 0.8f);
            GameManager1.MaruBatsu1.SetActive(true);
            GameManager1.MaruBatsu2.SetActive(true);
            GameManager1.MaruBatsu3.SetActive(true);
            GameManager1.MaruBatsu4.SetActive(true);

        }
    }
}
