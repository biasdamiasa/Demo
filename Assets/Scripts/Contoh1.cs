using System.Collections.Generic;
using UnityEngine;

public class Contoh1 : MonoBehaviour
{
    [SerializeField]
    List<Player> ListPlayer = new List<Player>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = ListPlayer.Find(item => item.Level > 5);

        Debug.Log(player.Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
