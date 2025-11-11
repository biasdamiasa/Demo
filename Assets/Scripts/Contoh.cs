using UnityEngine;

public class Contoh : MonoBehaviour
{
    
    
    void Start()
    {
        Player player = new Player();

        Player player2 = new Player();

        player.Name = "Bias";
        player.Level = 5;
        player.Health = 80;

        player.Name = "Damiasa";
        player.Level = 4;
        player.Health = 70;


        Debug.Log("Player 1");
        Debug.Log("Name: " + player.Name);    
        Debug.Log("Level: " + player.Level);
        Debug.Log("Health: " + player.Health);  
          
        Debug.Log("Player 2");
        Debug.Log("Name: " + player2.Name);    
        Debug.Log("Level: " + player2.Level);    
        Debug.Log("Health: " + player2.Health);    
    }

    
    void Update()
    {
        
    }
}
