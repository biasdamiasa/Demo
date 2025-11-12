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
    public void AddScore(int scoreValue)
    {
        score = score + scoreValue;
    }

    void OnDisable()
    {
        objectDeteksiInput.inputEvent -= AddScore;
    }

}
