using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	public GameObject door; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{
		door.animation.Play("doorAnim");
	}
}
