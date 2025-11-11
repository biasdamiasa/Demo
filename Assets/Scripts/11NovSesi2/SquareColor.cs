using UnityEngine;

public class SquareColor : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = Color.magenta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
