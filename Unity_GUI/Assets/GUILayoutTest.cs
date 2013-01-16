using UnityEngine;
using System.Collections;

public class GUILayoutTest : MonoBehaviour {

    string textFiled = "Your text here";
    bool toogle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        toogle = GUILayout.Toggle(toogle,"display Window");
        if (toogle)
        {
            GUILayout.Window(1, new Rect(200f, 200f, Screen.width * 0.25f, Screen.height * 0.25f), MyWindow, "Test Window");
        }
        
    }

    void MyWindow(int windowID)
    {
        GUILayout.Label("Hello World");
        GUILayout.Button("Button");
        textFiled = GUILayout.TextField(textFiled);
    }

}
