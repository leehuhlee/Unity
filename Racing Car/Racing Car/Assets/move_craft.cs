using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_craft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //float xmoverate = 5 * Time.deltaTime; //이동
        float xrot_rate = 120 * Time.deltaTime; //회전
        float zmoverate = 5 * Time.deltaTime;
        float dirx = Input.GetAxis("Horizontal"); // 키입력을받는다.
        //범위 -1~1 입력이 없으면 0
        float dirz = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward * zmoverate * dirz);
        //this.transform.Translate(Vector3.right * xmoverate* dirx);
        // 이동수치 *Time.deltatime;
        //vector3.zero Vector3.up Vector3.forward
        // 0,0,0          0,1,0     0,0,1

        this.transform.Rotate(Vector3.up*dirx*xrot_rate);
   
	}

    void OnCollisionEnter(Collision other)
    {
        print("hit with "+other.gameObject.name);
        Debug.Log("avoid "+ other.gameObject.tag);
        //if(other.gameObject.name != "Plane")
        //     Destroy(other.gameObject);
        if (other.gameObject.name == "Pass")
            print("Game End");
    }

    void OnTriggerEnter(Collider other)
    {
        print("Pass");
    }
}
