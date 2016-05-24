using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {
    public int Health;//

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)//Determines what loses health by which bullet
    {

        if (this.gameObject.tag=="Player" && other.gameObject.tag=="tBullet")//Checks if the health belongs to the player and the colliding bullet belongs to a turret
        {
            this.Health--;//Player lose 1 point of health
            other.gameObject.SetActive(false);//Turns off the bullet as it hits the player
        }
        if (this.gameObject.tag == "Turret" && other.gameObject.tag == "pBullet")//Checks if the health belongs to the turret and the colliding bullet belongs to the player
        {
            this.Health--;//Turret lose 1 point of health
            other.gameObject.SetActive(false);//bullet is turned off as it hits the turret
            if(Health<=0)//checks if the turret health is 0
            {
                this.gameObject.SetActive(false);//removes turret when health is 0
  
            }
        }
        
    }
}
