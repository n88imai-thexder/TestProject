// GITのテスト用

using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		print("TEST TEST");
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 rot;
		rot.x = Random.Range( 0.0f, 360.0f );
		rot.y = Random.Range( 0.0f, 360.0f );
		rot.z = Random.Range( 0.0f, 360.0f );
		transform.localEulerAngles = rot;




	
	}
}
