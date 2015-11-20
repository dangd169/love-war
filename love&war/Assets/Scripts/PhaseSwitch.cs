using UnityEngine;
using System.Collections;

public class PhaseSwitch : MonoBehaviour {


	public SpriteRenderer vote;
	public SpriteRenderer blame;
	
	void Update () {

		if(BlameCounter.blameTime == 0){
			vote.enabled = true;
			blame.enabled = false;
		}

		if(BlameCounter.blameTime == BlameCounter.timerStart - 1){
			vote.enabled = false;
			blame.enabled = true;
		}
	}

}
