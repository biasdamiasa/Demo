using UnityEngine;

public class Contoh1 : MonoBehaviour
{
    [SerializeField]
    string[] Nama = new string[3];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Nama[0]);
        Debug.Log(Nama[1]);
        Debug.Log(Nama[2]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
