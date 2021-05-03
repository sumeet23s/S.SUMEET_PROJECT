using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLine : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public void Start()
    {
        //score = GetComponent<Text>();
        score = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        
        score.text = scoreValue.ToString();
    }
}
