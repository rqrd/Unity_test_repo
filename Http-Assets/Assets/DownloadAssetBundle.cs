using UnityEngine;
using System.Collections;

public class DownloadAssetBundle : MonoBehaviour {
	
	WWW wwwProcessor;
	public GameObject obj;
	
	// Use this for initialization
	void Start () {
		
		
		
	wwwProcessor = new WWW("file:///"+ Application.dataPath + "/test_AssetBundle.unity3d");
			
	}
	
	// Update is called once per frame
	void Update () {
	
		if(wwwProcessor.isDone)
		{
			if(wwwProcessor.assetBundle  != null)
			{
				obj = GameObject.Instantiate(wwwProcessor.assetBundle.mainAsset) as GameObject;
				this.enabled = false;
				return;
			}
		}
		
	}
}
