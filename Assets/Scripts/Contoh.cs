using UnityEngine;

public class Contoh : MonoBehaviour
{
    // Vector2 position1 = new Vector2(5, 1);

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int kali(int a, int b, int c)
    {
        return a * b * c;
    }

    void Start()
    {
        Debug.Log(kali(1, 2, 3));
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello World");        
    }
}
