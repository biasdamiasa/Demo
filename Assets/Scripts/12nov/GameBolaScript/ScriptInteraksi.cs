using TMPro;
using UnityEngine;

public class ScriptInteraksi : MonoBehaviour
{
    // deklarasi referensi ke class ScriptSquareMove
    public ScriptSquareMove scriptSquareMove;

    //deklarasi variabel score
    public int score;

    //deklarasi referensi object ke gameObject ScoreText
    public TMP_Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // method yang dipanggil Button Atas untuk mengubah gerak Square ke atas
    public void GerakAtas()
    {
        scriptSquareMove.arahgerak = ArahGerak.atas;
    }

    // method yang dipanggil Button Bawah untuk mengubah gerak Square ke bawah
    public void GerakBawah()
    {
        scriptSquareMove.arahgerak = ArahGerak.bawah;
    }

    // method yang dipanggil Button Atas untuk mengubah gerak Square ke kanan
    public void GerakKanan()
    {
        scriptSquareMove.arahgerak = ArahGerak.kanan;
    }
    
    // method yang dipanggil Button Atas untuk mengubah gerak Square ke kiri
    public void GerakKiri()
    {
        scriptSquareMove.arahgerak = ArahGerak.kiri;
    }
}
