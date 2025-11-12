using TMPro;
using UnityEngine;

public class ScriptInteraksi : MonoBehaviour
{
    public ScriptSquareMove scriptSquareMove;
    public int score;
    public TMP_Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GerakAtas()
    {
        scriptSquareMove.arahgerak = ArahGerak.atas;
    }

    public void GerakBawah()
    {
        scriptSquareMove.arahgerak = ArahGerak.bawah;
    }

    public void GerakKanan()
    {
        scriptSquareMove.arahgerak = ArahGerak.kanan;
    }
    
    public void GerakKiri()
    {
        scriptSquareMove.arahgerak = ArahGerak.kiri;
    }
}
