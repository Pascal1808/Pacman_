using UnityEngine;
using System.Collections;

public class Delay : MonoBehaviour
{
    public float spawnDelay = 0;
    public GameObject Burrr;
    public GameObject ghost;
    void Start()
    {
       Burrr.SetActive(false);
       ghost.SetActive(false);
        StartCoroutine(ActivateObjectAfterDelay());
    }
    private IEnumerator ActivateObjectAfterDelay()
    {
        yield return new WaitForSeconds(spawnDelay);
        Burrr.SetActive(true);
        ghost.SetActive(true);
    }
}
