using UnityEngine;
using TMPro;

public class AnswerBlock : MonoBehaviour
{
    private Judge1 judge1;
    private Portal portal;
    private void Start()
    {
        judge1 = GetComponent<Judge1>();
        portal = FindObjectOfType<Portal>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("a");
            judge1.answerText = other.GetComponentInChildren<TextMeshProUGUI>();
            judge1.AnswerJudge();
            portal.TriggerTeleport(GetComponent<Collider2D>());
            // 審判処理の呼び出し
            // Judge.SetAnswerText(answerText.text);
        }
    }
}
