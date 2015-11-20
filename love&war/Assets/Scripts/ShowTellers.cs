using UnityEngine;
using System.Collections;

public class ShowTellers : MonoBehaviour {


	public SpriteRenderer blame;
	public SpriteRenderer votes;
	public SpriteRenderer truths;

	void Update(){

		if (BlameCounter.blameTime == KeepScore.voteSwitch + 1){
			votes.enabled = true;
		}
		if (BlameCounter.blameTime == KeepScore.blameSwitch + 1){
			votes.enabled = false;
			blame.enabled = true;
		}
		if (BlameCounter.blameTime == KeepScore.truthSwitch + 1){
			blame.enabled = false;
			truths.enabled = true;
		}
		if (BlameCounter.blameTime == BlameCounter.timerLength + 1){
			truths.enabled = false;
		}

	}

}