using UnityEngine;
using System.Collections;

public class BulletBlocker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tBullet" || other.gameObject.tag == "pBullet")//checks if colliding object is a bullet
        {
            other.gameObject.SetActive(false);//deactivates the bullet
        }
    }
}
