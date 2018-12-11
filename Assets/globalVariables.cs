using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class globalVariables : MonoBehaviour {

    public static float speed = 2f;
    public static bool startFaster = false; 
    public static bool lessDistance = false;
    public static bool visibleLater = true;
    public static int[] topScores = new int[11];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void addScore(float score)
    {
        topScores[10] = (int) score;

            int i, j;
            int N = topScores.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (topScores[i] < topScores[i + 1])
                    {
                        int temp = topScores[j - 1];
                        topScores[j - 1] = topScores[j];
                        topScores[j] = temp;
                    }
                }
            }
        

    }

    public static int[] getScores()
    {
        return topScores;
    }


}
