using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		int[] money = new int[5];


		money [0] = 30;
		money [1] = 20;
		money [2] = 50;
		money [3] = 10;
		money [4] = 80;


		for (int i = 4; i >= 0; i--) {
			Debug.Log (money [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
