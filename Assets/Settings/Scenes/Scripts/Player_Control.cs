using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 4;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // 矢印キー入力
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");

        // スピード調整（斜め移動速度の補正）
        if (MoveX != 0 && MoveY != 0)
        {
            // 斜め移動時に移動速度を調整
            rb.velocity = new Vector2(MoveX * moveSpeed * 0.707f, MoveY * moveSpeed * 0.707f);
        }
        else
        {
            // 通常の上下左右移動
            rb.velocity = new Vector2(MoveX * moveSpeed, MoveY * moveSpeed);
        }
    }

}