using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "score_box")
        {
             BasketControl.gamescore += 1;
            print(BasketControl.gamescore);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
