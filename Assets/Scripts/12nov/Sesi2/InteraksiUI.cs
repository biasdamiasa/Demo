using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public TMP_Text TeksBerubah;
    public TMP_Text NamaBerubah;

    public GameObject SquareUbahWarna;

    public List<string> daftarNama;
    public int idNama = 0;

    void Start()
    {
        NamaBerubah.text = daftarNama[0];    
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void UbahTeksKiri()
    {
        string teks = "kiri";
        TeksBerubah.text = teks;
    }

    public void UbahTeksKanan()
    {
        string teks = "kanan";
        TeksBerubah.text = teks;
    }

    public void LanjutNama()
    {
        if (idNama < daftarNama.Count - 1)
        {                
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        NamaBerubah.text = daftarNama[idNama];
    }

    public void KembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        NamaBerubah.text = daftarNama[idNama];
    }

    public void UbahWarna(Color warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }

    public void UbahMerah()
    {
        UbahWarna(Color.red);
    }

    public void UbahKuning()
    {
        UbahWarna(Color.yellow);
    }

    public void UbahHijau()
    {
        UbahWarna(Color.green);

    }
    
    public void UbahRandom()
    {
        Color col = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        UbahWarna(col);        
    }
}
