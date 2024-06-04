using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionHandling : MonoBehaviour
{
    [SerializeField]
    private PointAdd pointAdd;

    [SerializeField]
    private GameObject text;

    [SerializeField]
    private GameObject button;

    [SerializeField]
    private Record record;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Block")
        {
            Debug.Log("GameOver");

            text.SetActive(true);

            text.GetComponent<Text>().text = $"Max score: {record.MaxScore}";

            record.SetMaxScore(pointAdd.Point); 

            button.SetActive(true);

            Time.timeScale = 0;
        }

        else if (other.gameObject.tag == "Point")
        {
            pointAdd.AddPoint();
        }
    }
}
