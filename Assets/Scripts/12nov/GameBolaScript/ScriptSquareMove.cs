using UnityEngine;


public class ScriptSquareMove : MonoBehaviour
{
    public ArahGerak arahgerak = ArahGerak.kanan;
    public ScriptInteraksi scriptInteraksi;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (arahgerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            if (arahgerak == ArahGerak.kanan)
            {
                arahgerak = ArahGerak.kiri;
            }
            else if (arahgerak == ArahGerak.kiri)
            {
                arahgerak = ArahGerak.kanan;
            }
            else if (arahgerak == ArahGerak.atas)
            {
                arahgerak = ArahGerak.bawah;
            }
            else
            {
                arahgerak = ArahGerak.atas;
            }
            Debug.Log("Menabrak dinding");
            TambahSkor();
        }
    }

    public void TambahSkor()
    {
        scriptInteraksi.score++;
        scriptInteraksi.ScoreText.text = "Skor: " + scriptInteraksi.score;
    }
}

public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan
}
