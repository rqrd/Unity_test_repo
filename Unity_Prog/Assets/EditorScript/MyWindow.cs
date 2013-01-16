using UnityEditor;
using UnityEngine;

using System.IO;

public class MyWindow : EditorWindow
{
	string myString = "Hello World";
	bool groupEnabled;
	bool myBool = true;
	float myFloat = 1.23f;

	// Add menu item named "My Window" to the Window menu
	[MenuItem("MyTools/Test")]
	public static void ShowWindow()
	{
		//Show existing window instance. If one doesn't exist, make one.
		EditorWindow.GetWindow(typeof(MyWindow));
	}
	
	
	void OnGUI()
	{
		GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
		
		if(GUILayout.Button("Ranger Assets"))
		{
			Ranger ();
					
		}
		
		if(GUILayout.Button ("Other"))
		{
			Other();	
		}
	}
	
	void Other()
	{
		
	}
	
	void Ranger()
	{	
		string assetPath = Application.dataPath;
		Debug.Log(assetPath);
		
		string texturesPath = assetPath + @"/Textures";
		
		Debug.Log(texturesPath);
		
		DirectoryInfo info =  Directory.CreateDirectory(texturesPath);
		
		Debug.Log( info.ToString() );
		
		string[] files = Directory.GetFiles(assetPath);
		
		foreach(string filePath in files)
		{
			FileInfo currentFileInfo = new FileInfo(filePath);
			Debug.Log(currentFileInfo.Extension);
			switch(currentFileInfo.Extension)
			{
				case ".gif" : MoveToTextureDir(filePath, texturesPath); break;
				case ".jpg" : MoveToTextureDir(filePath, texturesPath); break;
				case ".png" : MoveToTextureDir(filePath, texturesPath); break;
			default : break;
			}
			
		}
	}
	
	void MoveToTextureDir(string filepath, string texturePath)
	{
		FileInfo info = new FileInfo(filepath);
		Debug.Log(info.Name);
		
		File.Move(filepath, texturePath + "/" + info.Name);
		
	}
}
