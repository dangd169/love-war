using UnityEngine;
using System.Collections;

public class BlameB : MonoBehaviour {

	public bool blameA;
	public bool blameB;
	public bool blameC;
	public bool blameD;
	public bool blame;
	
	public bool voteA;
	public bool voteB;
	public bool voteC;
	public bool voteD;
	public bool vote;

	public bool truth;
	public GameObject question;
	
	void Update(){
		
		
	}
	
	
	void OnTriggerStay2D(Collider2D other){
		
		if(other.CompareTag("BLAMEA")){
			if(Input.GetButtonDown("Select2")){
				blameA = true;
				blameB = false;
				blameC = false;
				blameD = false;
				blame = true;
			}
		}
		
		if(other.CompareTag("BLAMEB")){
			if(Input.GetButtonDown("Select2")){
				blameA = false;
				blameB = true;
				blameC = false;
				blameD = false;
				blame = true;
			}
		}
		
		if(other.CompareTag("BLAMEC")){
			if(Input.GetButtonDown("Select2")){
				blameA = false;
				blameB = false;
				blameC = true;
				blameD = false;
				blame = true;
			}
		}
		
		if(other.CompareTag("BLAMED")){
			if(Input.GetButtonDown("Select2")){
				blameA = false;
				blameB = false;
				blameC = false;
				blameD = true;
				blame = true;
			}
		}
		
		if(other.CompareTag("VOTEA")){
			if(Input.GetButtonDown("Select2")){
				voteA = true;
				voteB = false;
				voteC = false;
				voteD = false;
				vote = true;
				if(question.CompareTag("QUESTION1")){
					truth = false;
				}
			}
		}
		
		if(other.CompareTag("VOTEB")){
			if(Input.GetButtonDown("Select2")){
				voteA = false;
				voteB = true;
				voteC = false;
				voteD = false;
				vote = true;
				if(question.CompareTag("QUESTION1")){
					truth = true;
				}
			}
		}
		
		if(other.CompareTag("VOTEC")){
			if(Input.GetButtonDown("Select2")){
				voteA = false;
				voteB = false;
				voteC = true;
				voteD = false;
				vote = true;
				if(question.CompareTag("QUESTION1")){
					truth = false;
				}
			}
		}
		
		if(other.CompareTag("VOTED")){
			if(Input.GetButtonDown("Select2")){
				voteA = false;
				voteB = false;
				voteC = false;
				voteD = true;
				vote = true;
				if(question.CompareTag("QUESTION1")){
					truth = false;
				}
			}
		}
}
}
