using TMPro;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    public int angka;
    public TMP_Text teksAngka;

    public SquareMoveNov13 squareMoveNov13;

    public GameObject bolaJatuh;

    public SquarePemain squarePemain;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teksAngka.text = "Angka: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Klik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("Posisi mouse ada di " + vector.ToString());
            KurangAngka();
            UpdateAngka();
            ToggleKiri();
            MunculDariAtas();
            squarePemain.Lompat();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik kanan");
            TambahAngka();
            UpdateAngka();
            ToggleKanan();
        }
    }

    void TambahAngka()
    {
        angka++;
    }

    void KurangAngka()
    {
        angka--;
    }

    void UpdateAngka()
    {
        teksAngka.text = "Angka: " + angka.ToString();
    }

    void ToggleKiri()
    {
        squareMoveNov13.isMoveRight = false;
    }

    void ToggleKanan()
    {
        squareMoveNov13.isMoveRight = true;
    }

    void MunculDariAtas()
    {
        // ambil posisi kursor
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //ambil posisi titik paling atas layar
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));

        //gunakan posisi x kursor dan posisi y dari titik paling atas layar
        Vector3 posisiJatuh = new Vector3 (posisiKlik.x, titikAtas.y, 0);

        //memunculkan object bola (bolaJatuh) di posisijatuh dengan rotasi Quaternion identity
        Instantiate(bolaJatuh, posisiJatuh, Quaternion.identity);
    }
}
