using UnityEngine;
using System.Collections;

public class DownloadTexture : MonoBehaviour {
	
	WWW wwwProcessor;
	
	// Use this for initialization
	void Start () {
		wwwProcessor = new WWW("http://upload.wikimedia.org/wikipedia/fr/b/b6/Logo_Unity.jpg");
	}
	
	// Update is called once per frame
	void Update () {
		if(wwwProcessor.isDone)
		{
			if(wwwProcessor.texture != null)
			{
				GameObject go = new GameObject("wwwTexture");
				GUITexture guiTextu = go.AddComponent<GUITexture>();
				
				go.transform.position = new Vector3(0.5f,0.5f,0f);
				
				
				guiTextu.texture = wwwProcessor.texture;
			
				guiTextu.pixelInset = new Rect(0f,0f, 1f,1f);
				
				this.enabled = false;
				 return;
			}				
		}		
	}
	
	void CreateGUITexture()
	{}
	
	void OnGUI()
	{
/*		if(wwwProcessor.isDone)
		{
			if(wwwProcessor.texture != null)
			{
				GUILayout.Box(wwwProcessor.texture);
			}				
		}
		*/
	}
	
}
