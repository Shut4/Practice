using UnityEngine;
public class Portal : MonoBehaviour
{
    [SerializeField] private Transform destination;
    private float distance = 0.3f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Vector2.Distance(transform.position, collision.transform.position) > distance)
            collision.transform.position = new Vector2(destination.position.x, destination.position.y);
    }
}