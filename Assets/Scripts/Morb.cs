using UnityEngine;
using TMPro;

public class Morb : MonoBehaviour
{
    private TextMeshProUGUI MorbText;
    public int morbsToGive = 1;

    private void Start()
    {
        MorbText = GameObject.FindWithTag("MorbText").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pacman player = collision.gameObject.GetComponent<Pacman>();
            player.Morbs += morbsToGive;
            MorbText.text = player.Morbs.ToString();
            Destroy(gameObject);
        }
    }
}
