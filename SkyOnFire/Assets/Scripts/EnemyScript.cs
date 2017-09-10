using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yeehaw");

        if(other.name == "PlayerShip")
        {
            Debug.Log("buh");
        }
    }
}
