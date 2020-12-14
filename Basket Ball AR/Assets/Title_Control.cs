using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Title_Control : MonoBehaviour {
    public void Next_Scene()
    {

        SceneManager.LoadScene("scene2");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
