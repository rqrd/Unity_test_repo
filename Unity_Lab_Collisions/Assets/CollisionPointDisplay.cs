using UnityEngine;
using System.Collections;

public class CollisionPointDisplay : MonoBehaviour {
	
	public GameObject templatePoint;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionStay(Collision col)
	{
		foreach(ContactPoint currentContact in col.contacts)
		{			
			if(templatePoint != null)
			{
				
				Object.Instantiate(templatePoint,currentContact.point,Quaternion.identity);
			}
		}
	}

}
