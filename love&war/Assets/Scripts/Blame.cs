using UnityEngine;
using System.Collections;

public class Blame : MonoBehaviour {
	
	public bool blame;
	public bool vote;

	void OnTriggerStay2D(Collider2D other){

		if(other.CompareTag("BLAMEA")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase1[0] = "a";
			}
		}

		if(other.CompareTag("BLAMEB")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase1[0] = "b";
			}
		}

		if(other.CompareTag("BLAMEC")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase1[0] = "c";
			}
		}

		if(other.CompareTag("BLAMED")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase1[0] = "d";
			}
		}

		if(other.CompareTag("VOTEA")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase2[0] = "a";

			}
		}

		if(other.CompareTag("VOTEB")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase2[0] = "b";
			}
		}

		if(other.CompareTag("VOTEC")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase2[0] = "c";
			}
		}

		if(other.CompareTag("VOTED")){
			if(Input.GetButtonDown("Select1")){
				KeepScore.phase2[0] = "d";
			}
		}
		
	
		
	
		
	




	}

}
