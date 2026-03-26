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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Morb")
        {
            Morbs++;
            Destroy(gameObject);
            Animator.Play("Power_upp");
        }

        if (collision.CompareTag("Burrr"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
    [Header("Animator Settings")]
    public Animator animator;

    [Header("Power-Up Settings")]
    public string powerUpTriggerName = "PowerUp";
    public string normalStateName = "Idle";
    public float powerUpDuration = 5f;

    private bool isPoweredUp = false;
    private float powerUpTimer = 0f;

    void Update()
    {
        if (isPoweredUp)
        {
            powerUpTimer -= Time.deltaTime;
            if (powerUpTimer <= 0f)
            {
                EndPowerUp();
            }
        }
    }

    public void ActivatePowerUp()
    {
        if (animator == null)
        {
            Debug.LogError("Animator not assigned!");
            return;
        }

        isPoweredUp = true;
        powerUpTimer = powerUpDuration;

        animator.ResetTrigger(powerUpTriggerName);
        animator.SetTrigger(powerUpTriggerName);
    }

    private void EndPowerUp()
    {
        isPoweredUp = false;

        animator.Play(normalStateName);
    }
}


