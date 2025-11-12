using UnityEngine;

public class Score : MonoBehaviour
{
    public DeteksiInput objectDeteksiInput;
    public int score;

    private void OnEnable()
    {
        objectDeteksiInput.inputEvent += AddScore;
    }

    // Update is called once per frame
    public void AddScore()
    {
        score = score + 1;
    }

    void OnDisable()
    {
        objectDeteksiInput.inputEvent -= AddScore;
    }

}
