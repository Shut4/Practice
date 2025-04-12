using UnityEngine;

public class Player_move_new : MonoBehaviour
{
    private float speed = 200f;
    private Rigidbody2D rb;
    private Rigidbody2D rb2D;
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        // キャラクターの大きさ。負数にすると反転される
        Vector3 scale = transform.localScale;
        if (rb2D.velocity.x > 1)      // 右方向に動いている
            scale.x = 1;  // 通常方向(スプライトと同じ右向き)
        else if (rb2D.velocity.x < -1) // 左方向に動いている
            scale.x = -1; // 反転
        // 更新
        transform.localScale = scale;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}