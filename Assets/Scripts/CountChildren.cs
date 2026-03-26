using UnityEngine;

public class CountChildren : MonoBehaviour
{
    public GameObject winUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(transform.childCount);
        if (transform.childCount == 0)
        {
            winUI.SetActive(true);

        }
    }
}
