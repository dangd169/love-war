using UnityEngine;
using System.Collections;

public class Blame : MonoBehaviour {
	
	public SpriteRenderer A;
	public SpriteRenderer B;
	public SpriteRenderer C;
	public SpriteRenderer D;


	void OnTriggerStay2D(Collider2D other){

		if(this.tag == "A"){
			if(Input.GetButtonDown("Select1")){

		if(other.CompareTag("BLAMEA")){
				KeepScore.phase1[0] = "a";
				GetComponent<SpriteRenderer>().enabled = false;
				A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("BLAMEB")){
				KeepScore.phase1[0] = "b";
				GetComponent<SpriteRenderer>().enabled = false;
				B.enabled = true;
					A.enabled = false;
					C.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("BLAMEC")){
				KeepScore.phase1[0] = "c";
				GetComponent<SpriteRenderer>().enabled = false;
				C.enabled = true;
					B.enabled = false;
					A.enabled = false;
					D.enabled = false;
		}

		if(other.CompareTag("BLAMED")){
				KeepScore.phase1[0] = "d";
				GetComponent<SpriteRenderer>().enabled = false;
				D.enabled = true;
					B.enabled = false;
					C.enabled = false;
					A.enabled = false;
		}

		if(other.CompareTag("VOTEA")){
				KeepScore.phase2[0] = "a";
		}

		if(other.CompareTag("VOTEB")){
				KeepScore.phase2[0] = "b";
		}

		if(other.CompareTag("VOTEC")){
				KeepScore.phase2[0] = "c";
		}

		if(other.CompareTag("VOTED")){
				KeepScore.phase2[0] = "d";
		}
		}
		}

		if(this.tag == "B"){
			if(Input.GetButtonDown("Select2")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[1] = "a";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[1] = "b";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[1] = "c";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[1] = "d";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[1] = "a";
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[1] = "b";
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[1] = "c";
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[1] = "d";
				}
			}
		}

		if(this.tag == "C"){
			if(Input.GetButtonDown("Select3")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[2] = "a";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[2] = "b";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[2] = "c";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[2] = "d";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[2] = "a";
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[2] = "b";
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[2] = "c";
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[2] = "d";
				}
			}
		}

		if(this.tag == "D"){
			if(Input.GetButtonDown("Select4")){
				
				if(other.CompareTag("BLAMEA")){
					KeepScore.phase1[3] = "a";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = true;
					B.enabled = false;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEB")){
					KeepScore.phase1[3] = "b";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = true;
					C.enabled = false;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMEC")){
					KeepScore.phase1[3] = "c";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = false;
					C.enabled = true;
					D.enabled = false;
				}
				
				if(other.CompareTag("BLAMED")){
					KeepScore.phase1[3] = "d";
					GetComponent<SpriteRenderer>().enabled = false;
					A.enabled = false;
					B.enabled = false;
					C.enabled = false;
					D.enabled = true;
				}
				
				if(other.CompareTag("VOTEA")){
					KeepScore.phase2[3] = "a";
				}
				
				if(other.CompareTag("VOTEB")){
					KeepScore.phase2[3] = "b";
				}
				
				if(other.CompareTag("VOTEC")){
					KeepScore.phase2[3] = "c";
				}
				
				if(other.CompareTag("VOTED")){
					KeepScore.phase2[3] = "d";
				}
			}
		}
	
		
	
		
	




	}

}
