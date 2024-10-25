//Script for enemy artificial intelligence.//

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 2.0f;

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;
    }
}
