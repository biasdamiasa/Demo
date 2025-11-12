using UnityEngine;

public class DeteksiInput : MonoBehaviour
{
    public Score objectScore;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectScore.AddScore();
        }
    }
}
