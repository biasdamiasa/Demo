using UnityEngine;

public class GerakTriangle : MonoBehaviour
{
    public GameObject _triangleGerak;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _triangleGerak.transform.Translate(5 * Time.deltaTime, 0, 0);
    }
}
