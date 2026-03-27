using UnityEngine;

public class Delay : MonoBehaviour
{
    public int spawnDelay = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Invoke ("SpawnDelay", spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnDelay()
    {
        gameObject.SetActive(true);
    }
}
