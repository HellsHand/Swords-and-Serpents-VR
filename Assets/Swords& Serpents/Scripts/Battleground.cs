using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleground : MonoBehaviour {

    private GameObject player;
    public Transform battleground;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("[S&SCameraRig]");
        player.transform.position = battleground.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
