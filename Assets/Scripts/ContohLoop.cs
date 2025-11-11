using UnityEngine;

public class ContohLoop : MonoBehaviour
{
    int result = 1;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 4; i >= 1; i--)
        {
            result *= i;
        }

        Debug.Log(result);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
