using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float limit = 6f;  // 制限時間
    float now = 0f; // 経過時間
    public TextMeshProUGUI time;    //現在の時間
    public Slider timerGauge;   //残り時間ゲージ

    void Start()
    {
        timerGauge.value = 1f;  //制限時間ゲージ
    }

    void Update()
    {
        // 時間制御
        now += Time.deltaTime; // タイマー
        Debug.Log(now);
        float t = now / limit; // スライダーの値ー正規化
        timerGauge.value = Mathf.Lerp(1f, 0f, t);
        float timeLimit = limit - now; // 残り時間
        timeLimit = Mathf.Max(timeLimit, 0f);
        string timeLog = timeLimit.ToString("F0");
        time.text = timeLog + "秒";
        time.color = (timeLimit > 1.5f) ? Color.green : Color.red; // 文字の色（1.5秒以上は緑、未満は赤）
    }
}