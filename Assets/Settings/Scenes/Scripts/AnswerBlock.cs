using UnityEngine;
using TMPro;

public class AnswerBlock : MonoBehaviour
{
    private TextMeshProUGUI portalText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TextMeshProUGUI portalText = other.GetComponentInChildren<TextMeshProUGUI>();
            Debug.Log(other.name);
            Judge1 judge1 = GetComponent<Judge1>();
            judge1.answerText.text = portalText.text;

            // AnswerBlockのテキストコンポーネントを取得
            // TextMeshProUGUI answerText = GetComponentInChildren<TextMeshProUGUI>();

            // 審判処理の呼び出し
            // Judge1.Instance.SetAnswerText(answerText);
            // Judge1.Instance.AnswerJudge();
        }
    }
}
