using UnityEngine;
using UnityEngine.AI;

public class SquareMove : MonoBehaviour
{
    public bool isMoveRight = true;

    public float speed = 5.0f;
    public bool isMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // bergerak
        // ke kanan
        // ke kiri
        // tidak bergerak
        if (isMove)
        {
            // bergerak
            if (isMoveRight)
            {
                // ke kanan
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                // ke kiri
                gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);                
            }
        }
        else
        {
            // tidak bergerak
            gameObject.transform.Translate(0, 0, 0);                
        }
    }
}
