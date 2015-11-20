using UnityEngine;
using System.Collections;

public class CheckBlame : MonoBehaviour {


	public GameObject A;
	public GameObject B;
	public GameObject C;
	public GameObject D;

	public GameObject blameA;
	public GameObject blameB;
	public GameObject blameC;
	public GameObject blameD;

	public SpriteRenderer voteA;
	public SpriteRenderer voteB;
	public SpriteRenderer voteC;
	public SpriteRenderer voteD;

	public SpriteRenderer blackText;



	
	void Update () {
		Blame BlameA = A.GetComponent<Blame>();
		BlameB BlameB = B.GetComponent<BlameB>();
		BlameC BlameC = C.GetComponent<BlameC>();
		BlameD BlameD = D.GetComponent<BlameD>();

		if(BlameA.blame == true && BlameB.blame == true && BlameC.blame == true && BlameD.blame == true ){
			// LOAD NEW BLACK FACT, LOAD VOTING SYSTEM
			blameA.GetComponent<SpriteRenderer>().enabled = false;
			blameB.GetComponent<SpriteRenderer>().enabled = false;
			blameC.GetComponent<SpriteRenderer>().enabled = false;
			blameD.GetComponent<SpriteRenderer>().enabled = false;

			blameA.tag = "VOTEA";
			blameB.tag = "VOTEB";
			blameC.tag = "VOTEC";
			blameD.tag = "VOTED";

			voteA.enabled = true;
			voteB.enabled = true;
			voteC.enabled = true;
			voteD.enabled = true;
			blackText.enabled = true;
		

		}

	}
}
