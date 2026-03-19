using UnityEngine;

public class Morb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pacman Pacman = collision.gameObject.GetComponent<Pacman>();
            Pacman.Morbs += 1;
            Destroy(gameObject);
        }
    }
}
