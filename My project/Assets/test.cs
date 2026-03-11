using UnityEngine;

public class test : MonoBehaviour
{


    public string PlayerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello "+ PlayerName);
        Debug.LogWarning("2 ");
        Debug.LogError("3 ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
