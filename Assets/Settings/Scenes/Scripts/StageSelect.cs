using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public int Save_num; // 進行度を保存する変数
    public GameObject[] stageSelect = default; // ステージ選択ボタンの配列

    void Start()
    {
        // PlayerPrefsから現在のステージ進行度を取得
        Save_num = PlayerPrefs.GetInt("SCORE", 0);

        // ステージの解放状態をチェック
        for (int i = 0; i < stageSelect.Length; i++)
        {
            if (i < Save_num)
            {
                stageSelect[i].SetActive(true); // 解放済みのボタンを表示
            }
            else
            {
                stageSelect[i].SetActive(false); // 未解放のボタンを非表示
            }
        }
    }
}