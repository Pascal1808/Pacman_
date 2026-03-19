using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 3f;

    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        // Huidige waypoint
        Transform target = waypoints[currentWaypointIndex];

        // Beweeg naar target
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        // Check of we er zijn
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            // Volgende waypoint
            currentWaypointIndex++;

            // Loop terug naar begin
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}