using UnityEngine;
using System.Collections;

public class PlayeHealth : HealthManager {

	// Use this for initialization
	void Start () {
        this.Health = 10;//Sets player health
	}
	
	// Update is called once per frame
	void Update () {
	if(Health<=0)//Checks if player health is zero
    { print("You Lose");//Prints you lose
    Application.LoadLevel(Application.loadedLevel);//restarts the level when player dies
    }
	}

}
