using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Record", menuName = "ScriptableObjects/Record", order = 1)]
public class Record : ScriptableObject
{
    [SerializeField]
    private int maxScore;

    public int MaxScore
    {
        get { return maxScore; }
    }

    public void SetMaxScore(int score)
    {
        if (score > maxScore)
        {
            maxScore = score;
        }
    }
}
