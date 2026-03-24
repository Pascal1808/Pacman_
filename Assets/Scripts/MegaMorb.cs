using UnityEngine;

public class MegaMorb : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
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
