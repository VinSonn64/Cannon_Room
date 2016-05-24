using UnityEngine;
using System.Collections;

public class Targeting : Shoot {
    public Transform Turret1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")//Checks if the object Entering the zone is the player
        {
            Turret1.LookAt(other.transform);//Turret aims at the player
            TurretShoot();//Turret shoots
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")//Checks if the object Exiting the zone is the player
        {
            Turret1.LookAt(other.transform);//Turret aims at the player
            TurretShoot();//Turret Shoots
        }
    }
}
