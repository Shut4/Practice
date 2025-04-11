using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform destination;
    private float distance = 0.3f;

    public void TriggerTeleport(Collider2D collider)
{
    if (collider.CompareTag("Player")) // プレイヤーのみを対象とする
    {
        if (Vector2.Distance(transform.position, collider.transform.position) > distance)
        {
            collider.transform.position = destination.position;
        }
    }
}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerTeleport(collision); // 既存の処理を再利用
    }
}
