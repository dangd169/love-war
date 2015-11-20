using UnityEngine;
using System.Collections;

public class KeepScore : MonoBehaviour {

	public static string[] phase1 = {"a","b","d","c"};
	public static string[] phase2 = {"b","c","c","d"};
	public static string truth = "b";

	public int playerAscore = 0;
	public int playerBscore = 0;
	public int playerCscore = 0;
	public int playerDscore = 0;

	void Start () {	
		//keeping score example
		//if player a picks player b
		//phase1[0] = "b";

	
		// points for the truth
		if (phase2[0] == truth) playerAscore += 500;
		if (phase2[1] == truth) playerBscore += 500;
		if (phase2[2] == truth) playerCscore += 500;
		if (phase2[3] == truth) playerDscore += 500;

		print ("Truth PlayerA:" + playerAscore + " PlayerB:" + playerBscore + " PlayerC:" + playerCscore + " PlayerD:" + playerDscore);


		// minus points for getting blamed
		playerAscore -= occurrences("a", phase2) * 250;
		playerBscore -= occurrences("b", phase2) * 250;
		playerCscore -= occurrences("c", phase2) * 250;
		playerDscore -= occurrences("d", phase2) * 250;

		print ("-Blame PlayerA:" + playerAscore + " PlayerB:" + playerBscore + " PlayerC:" + playerCscore + " PlayerD:" + playerDscore);


		// plus points for changing minds
		playerAscore += occurrences(phase1[0], phase2) * 100;
		playerBscore += occurrences(phase1[1], phase2) * 100;
		playerCscore += occurrences(phase1[2], phase2) * 100;
		playerDscore += occurrences(phase1[3], phase2) * 100;

		print ("+Influence PlayerA:" + playerAscore + " PlayerB:" + playerBscore + " PlayerC:" + playerCscore + " PlayerD:" + playerDscore);

	}

	int occurrences(string item, string[] ary)
	{
		int count = 0;
		for (int i=0;i<ary.Length;i++)
		{
			if (ary[i] == item)
				count++;
		}
		return count;
	}

}
