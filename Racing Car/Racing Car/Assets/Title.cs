using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {
    float elapsedtime=0;
	// Use this for initialization
	void Start () {
		
	}
	public void Next_scene()
    {
        SceneManager.LoadScene("day1");
    }
	// Update is called once per frame
	void Update () {
        elapsedtime += Time.deltaTime;
        if (elapsedtime >=10.0f)
        {
            elapsedtime = 0;
            SceneManager.LoadScene("day1");
        }
	}
}
