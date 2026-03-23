using System.Collections;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public int Morbs = 0;
    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Morb")
        {
            Morbs++;
            Destroy(gameObject);
            Animator.Play("Power_upp");
        }
    }
}
