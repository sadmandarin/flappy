using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    private float speed = 8;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
