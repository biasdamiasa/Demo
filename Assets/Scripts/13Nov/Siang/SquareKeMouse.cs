using UnityEngine;

public class SquareKeMouse : MonoBehaviour
{
    // public Transform squareTransform;

    public Vector2 posisiKlik;

    // Update is called once per frame
    void Update()
    {
        // geser object ke mouse
        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // // transform merujuk ke component transform dari object Square
        // transform.position = Vector2.MoveTowards(transform.position, worldMousePosition, 0.1f);

        //geser object ke klik
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {            
            posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = Vector2.MoveTowards(transform.position, posisiKlik, 0.1f);

        
    }
}
