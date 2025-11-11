using UnityEngine;

public class Contoh1 : MonoBehaviour
{
    [SerializeField]
    Player[] ArrayPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < ArrayPlayer.Length; i++)
        {
            Debug.Log(ArrayPlayer[i].Name);
            Debug.Log(ArrayPlayer[i].Level);
            Debug.Log(ArrayPlayer[i].Health);
        }
        
        foreach (Player player in ArrayPlayer)
        {
            Debug.Log(player.Name);
            Debug.Log(player.Level);
            Debug.Log(player.Health);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
