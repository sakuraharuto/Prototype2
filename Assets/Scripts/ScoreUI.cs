using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text ScoreText;
 
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = PlayerController.WholeScore.ToString()+"/5";

    }
}
