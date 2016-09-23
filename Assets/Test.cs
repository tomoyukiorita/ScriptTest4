using UnityEngine;
using System.Collections;

public class Boss{
	private int hp = 50;
	private int power = 25;
	private int mp = 53;

	public void attack(){
		Debug.Log (this.power + "のダメージを与えた");
	
	}

	public void defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void magic(int magicattack){
		this.mp -= magicattack;

		Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");


		if(mp <= 3) {
			Debug.Log("MPが足りないため魔法が使えない。");
		}

	}

}

public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {

		Boss lastboss = new Boss ();

		lastboss.attack ();
		lastboss.defence (3);

		for (int i = 0; i < 10; i++) {
			lastboss.magic (5);
		}



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
