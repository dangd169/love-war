using UnityEngine;
using System.Collections;

public class BlameCounter : MonoBehaviour {

	static public bool blame = false;
	static public int blameTime = 10;
	public static int timerLength = -20;
	public static int timerStart = 10;

	void Update (){
		print (blameTime);
		if (blameTime == timerLength) {
			CancelInvoke();
			blameTimer();

	}
	}
	void blameTimer() {
		if (blame == true) {
			blameTime = timerStart;
			countdown();
			}
		}
	void countdown(){
		InvokeRepeating("minus", 0f, 1f);
	}
	void minus(){
		blameTime --;
	}
}
