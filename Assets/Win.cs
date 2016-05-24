using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

    public Transform Turret1;
    public Transform Turret2;
    public Transform Turret3;
    public Transform Turret4;
    public GameObject Key;
    public int key;
	// Use this for initialization
	void Start () {
        Key.SetActive(false);//Turns the key off at start
	}
	
	// Update is called once per frame
	void Update () {
        if(Turret4.gameObject.activeSelf==false && Turret3.gameObject.activeSelf==false && Turret2.gameObject.activeSelf==false && Turret1.gameObject.activeSelf==false && key==0)//Checks if all turrets are dead and player has no key
        {
            Key.SetActive(true);//Turns key on 
        }
	

	}  
    void OnTriggerEnter(Collider other)
        {
        if(other.gameObject.name=="Key")//checks if layer touches key
        {
            key = 1;//Give a key point
            Key.SetActive(false);//turn off key after picking it up
        }
        if(other.gameObject.name=="Exit" && key==1)//Checks if player reaches exit with one key
        {
            print("You Win");//prints you win
            Application.LoadLevel(Application.loadedLevel);//restarts level after player leaves with key
        }
    }
}
