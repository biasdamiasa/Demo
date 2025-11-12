using System;
using UnityEngine;
using UnityEngine.Events;

public class DeteksiInput : MonoBehaviour
{
    public UnityEvent inputEvent;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inputEvent?.Invoke();
        }
    }
}
