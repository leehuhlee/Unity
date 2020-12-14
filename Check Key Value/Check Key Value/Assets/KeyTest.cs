using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class KeyTest : MonoBehaviour {

    public Text keytext;
    // Use this for initialization
	void Start () {
        keytext.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	    foreach(KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyUp(key))
            {
                print(key.ToString());
                keytext.text = key.ToString();
            }
        }	
	}
}
