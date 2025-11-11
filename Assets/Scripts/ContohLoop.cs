using UnityEngine;

public class ContohLoop : MonoBehaviour
{
            
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string bintang = "";
        for(int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                bintang += "*";
            }
            bintang += "\n";
        }
        Debug.Log(bintang);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
