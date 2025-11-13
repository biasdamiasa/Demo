using UnityEditor.Analytics;
using UnityEngine;


public class ScriptSquareMove : MonoBehaviour
{   
    //deklarasi  variabel dari enum untuk menyimpan arah gerak kanan/kiri/atas/bawah
    public ArahGerak arahgerak = ArahGerak.kanan;
    
    //deklarasi referensi ke class ScriptInteraksi
    public ScriptInteraksi scriptInteraksi;

    // deklarasi variabel speed untuk gerak kotak
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // mengupdate gerak object berdasarkan nilai arahgerak kotak
        // jika nilai arahgerak adalah atas, maka akan mengupdate gerak hanya di koordinat y (+)
        // jika nilai arahgerak adalah bawah, maka akan mengupdate gerak hanya di koordinat y (-)
        // jika nilai arahgerak adalah kanan, maka akan mengupdate gerak hanya di koordinat x (+)
        // jika nilai arahgerak adalah kiri, maka akan mengupdate gerak hanya di koordinat x (-)
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

        // if(Input.GetKeyDown(KeyCode.A))
        // {
        //     gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        // }
        // else if (Input.GetKeyDown(KeyCode.D))
        // {
        //     gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        // }
        // else if (Input.GetKeyDown(KeyCode.W))
        // {
        //     gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
        // }
        // else
        // {
            
        // }

        if (scriptInteraksi.nyawa <= 0)
        {
            Time.timeScale = 0f;
            scriptInteraksi.gameOverObject.SetActive(true);
        }
    }


    // deklarasi method untuk mendeteksi collision
    // mengecek apabila yang mengalami collision adalah gameObject dengan Tag "Dinding"
    // jika terdeteksi menabrak gameoBject dengan tag "Dinding", dengan arahgerak kanan maka arahgerak akan diubah nilainya kiri
    // dst untuk mengubah arahgerak square menjadi berlawanan arah setiap terdeteksi tabrakan
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

            // memanggil method TambahSkor setelah mendeteksi tabrakan dan mengubah arahgerak
            TambahSkor();
        }

        if(collision.gameObject.CompareTag("Bola"))
        {
            KurangiNyawa();
        }
    }


    //untuk menambah skor dan mengupdate teks gameObject ScoreText
    public void TambahSkor()
    {
        //menambah nilai variabel score sebanyak 1
        scriptInteraksi.score++;

        //mengubah teks ScoreText dengan skor terbaru
        scriptInteraksi.ScoreText.text = "Skor: " + scriptInteraksi.score;
    }

    public void KurangiNyawa()
    {
        scriptInteraksi.nyawa--;

        scriptInteraksi.NyawaText.text = "Nyawa: " + scriptInteraksi.nyawa;
    }
}

//mendeklarasi enum untuk 4 macam arah gerak
public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan
}
