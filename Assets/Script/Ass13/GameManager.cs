using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assighnment13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //? 1- Instantiate two Player objects.
        Player player1 = new Player();
        Player player2 = new Player();
        
        //? 2- Call InitializePlayer() to set playerName and health for each Player object.
        player1.InitializePlayer("Gaza",70);
        player1.InitializePlayer("World",30);


        //? 3-  Use both versions of the Heal() method to demonstrate method
        player1.Heal(true);
        player2.Heal(false);

        player1.Heal(5);
        player2.Heal(10);

       //? 4- Call ShowPlayerCount() to display the total number of Player objects.
        Player.ShowPlayerCounters();
        
    }

    // Update is called once per frame
   
}
