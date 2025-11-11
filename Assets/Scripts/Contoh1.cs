using System.Collections.Generic;
using UnityEngine;

public class Contoh1 : MonoBehaviour
{
    [SerializeField]
    List<Player> ListPlayer = new List<Player>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player newPlayer = new Player("Samid", 10, 20);
        ListPlayer.Add(newPlayer);

        List<Player> highLevelPlayer = ListPlayer.FindAll(item => item.Level > 5);

        foreach (Player player in highLevelPlayer)
        {
            Debug.Log(player.Name);
        }

        // Player player = ListPlayer.Find(item => item.Level > 5);

        // Debug.Log(player.Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
