using System;
using UnityEngine;

public class DeteksiInput : MonoBehaviour
{
    public Action inputEvent;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inputEvent.Invoke();
        }
    }
}
