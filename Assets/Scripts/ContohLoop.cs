using UnityEngine;

public class ContohLoop : MonoBehaviour
{
    int nyawa = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (nyawa > 0)
        {
            nyawa--;
            Debug.Log("Sisa nyawa: " + nyawa);
        }
        Debug.Log("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
