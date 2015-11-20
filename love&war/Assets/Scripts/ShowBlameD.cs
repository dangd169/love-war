using UnityEngine;
using System.Collections;

public class ShowBlameD : MonoBehaviour {

	public SpriteRenderer A;
	public SpriteRenderer B;
	public SpriteRenderer C;
	public SpriteRenderer D;
	
	public GameObject player;
	
	void Update () {
		
		BlameD Blame = player.GetComponent<BlameD>();
		
		if(Blame.blameA == true){
			A.enabled = true;
			B.enabled = false;
			C.enabled = false;
			D.enabled = false;
		}
		
		if(Blame.blameB == true){
			A.enabled = false;
			B.enabled = true;
			C.enabled = false;
			D.enabled = false;
		}
		
		if(Blame.blameC == true){
			A.enabled = false;
			B.enabled = false;
			C.enabled = true;
			D.enabled = false;
		}
		if(Blame.blameD == true){
			A.enabled = false;
			B.enabled = false;
			C.enabled = false;
			D.enabled = true;
		}
		
		
	}
}
