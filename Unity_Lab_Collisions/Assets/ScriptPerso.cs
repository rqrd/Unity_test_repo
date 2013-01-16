using UnityEngine;
using System.Collections;

public class ScriptPerso : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float speedPerSecond = speed * Time.deltaTime;
		CharacterController cc ;
		
		//rigidbody.velocity = Input.GetAxis("Vertical") * Vector3.forward * speedPerSecond;
		transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * speedPerSecond * 20f);
		transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * speedPerSecond, Space.Self);
	}
}
