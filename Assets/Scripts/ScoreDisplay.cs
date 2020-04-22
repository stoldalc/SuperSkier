using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreDisplay : MonoBehaviour
{

    [SerializeField] Text currentScore;

    public SkierEntity skier;

    // Start is called before the first frame update
    void Start()
    {
        currentScore.text = "Points: " + skier.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.text = "Points: " + skier.score.ToString();
    }
}
