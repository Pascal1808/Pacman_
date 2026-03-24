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
    }
    [Header("Animator Settings")]
    public Animator animator; // Reference to the Animator component

    [Header("Power-Up Settings")]
    public string powerUpTriggerName = "PowerUp"; // Animator trigger for power-up animation
    public string normalStateName = "Idle";       // Default animation state
    public float powerUpDuration = 5f;            // Duration of power-up effect

    private bool isPoweredUp = false;
    private float powerUpTimer = 0f;

    void Update()
    {
        // Countdown for power-up duration
        if (isPoweredUp)
        {
            powerUpTimer -= Time.deltaTime;
            if (powerUpTimer <= 0f)
            {
                EndPowerUp();
            }
        }
    }

    // Call this when player picks up a power-up
    public void ActivatePowerUp()
    {
        if (animator == null)
        {
            Debug.LogError("Animator not assigned!");
            return;
        }

        isPoweredUp = true;
        powerUpTimer = powerUpDuration;

        // Trigger the power-up animation
        animator.ResetTrigger(powerUpTriggerName); // Avoid stacking triggers
        animator.SetTrigger(powerUpTriggerName);
    }

    // Revert to normal animation
    private void EndPowerUp()
    {
        isPoweredUp = false;

        // Play the normal animation state
        animator.Play(normalStateName);
    }
}


