using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControll : MonoBehaviour {

	//unituちゃん指定（）
	private GameObject unitychan;


	// Use this for initialization
	void Start () {
	
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		
		if ( this.transform.position.z + 5 < this.unitychan.transform.position.z ) {
			//自分自身をオブジェクトを破棄（追加）
			Destroy (this.gameObject);}
}
}