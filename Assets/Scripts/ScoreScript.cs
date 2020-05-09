using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public static int scorePlayer = 0;
    private TextMeshProUGUI txtScore;

    // Start is called before the first frame update
    void Start()
    {
        scorePlayer = 0;
        txtScore = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = scorePlayer.ToString();
        //GetComponent<UnityEngine.UI.Text>().text = scorePlayer.ToString();
    }

}
