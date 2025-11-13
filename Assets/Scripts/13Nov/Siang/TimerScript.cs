using System.Collections;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float waktu;
    public float maxWaktu;
    public TMP_Text textTimer;
    public bool waktuBerjalan = true;

    public KeyCode StartCoroutineKey;
    public KeyCode StopCoroutineKey;

    public Coroutine displayTimerCoroutine;
    
    //reference ke object progress A
    public Image progressFill;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(DisplayTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(StartCoroutineKey))
        {
            if(displayTimerCoroutine == null)
            {
                displayTimerCoroutine = StartCoroutine(DisplayTimer());
            }
        }

        if(Input.GetKeyDown(StopCoroutineKey))
        {
            if (displayTimerCoroutine != null)
            {
                StopCoroutine(displayTimerCoroutine);
            }
        }
    }

    IEnumerator DisplayTimer()
    {
        while (waktuBerjalan && waktu < maxWaktu)
        {
            waktu++;
            textTimer.text = waktu.ToString();
            progressFill.fillAmount = waktu / maxWaktu;

            yield return new WaitForSeconds(1);                    
        }

    }
}
