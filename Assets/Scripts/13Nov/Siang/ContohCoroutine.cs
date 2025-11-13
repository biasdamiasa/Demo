using System.Collections;
using UnityEngine;

public class ContohCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CobaCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // buat function IEnumerator untuk menggunakan coroutine
    IEnumerator CobaCoroutine()
    {
        Debug.Log("Perintah 1");

        yield return new WaitForSecondsRealtime(5);
        
        Debug.Log("Perintah 2");

    }
}
