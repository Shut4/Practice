using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // キャラクターの移動速度

    void Update()
    {
        // キーボード入力の取得
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // キャラクターを移動させる
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}