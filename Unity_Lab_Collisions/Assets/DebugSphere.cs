using UnityEngine;
using System.Collections;

public class DebugSphere : MonoBehaviour {
	
	public float timeLimit = 0.01f;
	
	float timer =0.0f;
	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(timer > timeLimit)
		{
			Object.Destroy(gameObject);
		}
		timer += Time.deltaTime;
	}
	
	
}
