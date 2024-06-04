using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointAdd : MonoBehaviour
{
    private Text text;

    private int point;

    public int Point
    {
        get { return point; }
    }

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = "" + point; 
    }

    public void AddPoint()
    {
        point++;
    }
}
