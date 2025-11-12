using System;
using UnityEngine;

public class DeteksiInput : MonoBehaviour
{
    public Action<int> inputEvent;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inputEvent.Invoke(5);
        }
    }
}
