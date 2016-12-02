using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	float rotSpeed = 750;

	public int zoom = 20;
	public int normal = 60;
	public float smooth = 5;

	private bool isZoomed = false;


	void OnMouseDrag(){
		float rotX = Input.GetAxis ("Mouse X") * rotSpeed * Mathf.Deg2Rad;
		float rotY = Input.GetAxis ("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
		transform.Rotate(Vector3.up, -rotX);
		//transform.Rotate(Vector3.right, -rotY);
		Debug.Log("Text x " + rotX + "Text y "  + rotY);
		//}

	}


	// Use this for initialization
	void Start () {

	}




	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(2)) {
			isZoomed = !isZoomed;
		}
		if (isZoomed) {
			//Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, zoom, Time.deltaTime * smooth);
			Camera.main.fieldOfView = 50;
		} else {
			Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, normal, Time.deltaTime * smooth);
		}
	}
}
