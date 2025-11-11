using UnityEngine;

public class ContohLoop : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("Pengulangan ke-" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
