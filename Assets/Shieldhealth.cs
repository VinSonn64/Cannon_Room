using UnityEngine;
using System.Collections;

public class Shieldhealth : HealthManager {

	// Use this for initialization
	void Start () {
        Health = 3;//Sets SHield Health
	}
	
	// Update is called once per frame
	void Update () {
        if (Health == 0)
        {
            this.gameObject.SetActive(false);//Deactivates shield when 0 health
        }
	}
}
