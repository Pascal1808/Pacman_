using UnityEngine;
public class ChasePlayer : MonoBehaviour
{
    public Transform Player;
    public float speed = 2f;

    void Update()
    {
        Vector3 direction = (Player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}

