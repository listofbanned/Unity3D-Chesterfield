using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class buttonScript : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject esfera;
	void Update() {
		//var component = GameObject.Find("Button").GetComponent<right>();
		//var _component = GameObject.Find("Button2").GetComponent<left>();
		/*
		if(component.count > 0) {
			mainCamera.transform.Rotate(0,-1,0);
			esfera.transform.Rotate(0,-1,0);
		}
		if(_component.count > 0) {
			mainCamera.transform.Rotate(0,1,0);
			esfera.transform.Rotate(0,1,0);
		}*/
		mainCamera.transform.Rotate(0,Input.acceleration.x,0);
		esfera.transform.Rotate(0,Input.acceleration.x,0);
	}
}