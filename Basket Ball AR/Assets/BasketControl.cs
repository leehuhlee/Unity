using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketControl : MonoBehaviour {
    public Text my_score;
    GameObject A; // 둘다 3D 객체를 받을 때 사용하지만
    Transform B; // GameObject는 모델데이터가 있는 객체를
    //Transform 모델데이터가 없거나 현재 보이는 것이 없는 개체를 받을 때 사용
    //=> 관용적으로 사용하는 규칙.

    //객체의 권한. public(소스코드 외부에서 보이고 사용가능 =>엔진에서 사용 가능),
    // private(현재 소스코드 내에서만 사용가능)
    // 아무것도 권한세팅 안하면 private
    static public int gamescore = 0;
    
    public GameObject basketBall;
    public Transform firepoint;
    Rigidbody ballrigid;

    public void ShootBall()
    {
        //발사점 기준으로 공을 발사
        //물리를 가지고 => 공 물리...->내부 속성 => 형식이 달라서 일반화(generic) 개념으로 사용한다.
        //내부 메서드 중 값을 세팅할 때 : set, 얻어올때 : get, 컴포넌트(내부속성)
        ballrigid.useGravity = true;
        ballrigid.AddForce(Vector3.up * 600f); // power값을 곱헤야
        ballrigid.AddForce(Vector3.forward *500f);// power값을 곱해야 함


    }

	// Use this for initialization
	void Start () {
        //Debug.Log();
        ballrigid = basketBall.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        my_score.text = gamescore.ToString();
        if (basketBall.transform.position.y <= -15f)
        {
            initball();
        }
    }

    void initball()
    {
        //위치 초기화
        basketBall.transform.position = firepoint.transform.position;
        basketBall.transform.eulerAngles = Vector3.zero; //회전
        ballrigid.velocity = Vector3.zero;
        ballrigid.angularVelocity = Vector3.zero;
        ballrigid.useGravity = false;
    }
}
