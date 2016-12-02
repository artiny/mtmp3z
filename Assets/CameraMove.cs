using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public Vector3 center; 
	Vector3 v =  Vector3.zero;
	public GameObject auto;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		auto = GameObject.Find("r8_gt_3ds");
		//v = v + new Vector3(0.1f, 0f,0f);

		v = v + 0.01f * (center - transform.position).normalized;
		transform.position = transform.position + v;
		transform.LookAt (auto.transform);
		MoveCenter ();
	}

	void MoveCenter(){
		Vector2 rand = 5 * Random.insideUnitCircle;
		Vector3 v3 = new Vector3 (rand.x, 0, rand.y);
		center = center + v3;
	}

}
