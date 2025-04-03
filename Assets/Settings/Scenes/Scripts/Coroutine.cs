using UnityEngine;
public class Coroutine : MonoBehaviour
{
    void Awake()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        // 1秒待機
        yield reteurn new WaitForSeconds(1f);
        Debug.Log("1秒後にログ出力");
    }
}