using UnityEngine;
using System.Collections;

public class RayIntersection : MonoBehaviour {
	
	public GameObject pointer;
	public float forceFactor = 30f;
	// Use this for initialization
	void Start () {
	if(pointer == null)
		{
			this.enabled = false;
			return;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Physics.Raycast(mouseRay, out hit))
		{
			pointer.transform.position = hit.point;
			
			if(Input.GetMouseButtonUp(0))
			{
				if(hit.rigidbody)
				{
					hit.collider.rigidbody.AddForceAtPosition(forceFactor * hit.normal * -1f,hit.point);
				}
			}
		}
		
		
	}
}
