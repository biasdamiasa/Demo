using UnityEngine;

public class SquarePemain : MonoBehaviour
{
    public bool diLantai;
    //variabel untuk menghitung daya lompat
    public float forceMultiplier = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lompat()
    {
        if (diLantai)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("Lagi lompat");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Lantai"))
        {
            Debug.Log("di lantai");
            diLantai = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Lantai"))
        {
            Debug.Log("di udara");
            diLantai = false;
        }   
    }
}
