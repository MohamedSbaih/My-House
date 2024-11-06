using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    //? Define public variable
 public string playerName ;
 public int health;
 public static int playerCount = 0;
 
//? Implement InitializePlayer method
public void InitializePlayer(string name, int initialHealth){
    playerName = name;
    health = initialHealth;
    playerCount ++;
}

public void Heal(int amount) {
     health += amount;
     Debug.Log("The ammount updated {health}");
}
public void Heal(bool fullRestore) {
    if(fullRestore){
        health = 100;
        Debug.Log($"{playerName} choose fully restore to {health}");
    }else{
        Debug.Log($"{playerName}  not fully restore {health}");
    }
     
}
public static void ShowPlayerCounters() {
    Debug.Log($"Player Count is  {playerCount}");
}


}
