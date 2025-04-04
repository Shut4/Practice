using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour
{
    void Awake()
    {
        StartCoroutine(Test());
    }

    public IEnumerator Test()
    {
        // 1秒待機
        yield return new WaitForSeconds(1f);
        Debug.Log("1秒後にログ出力");
    }
}