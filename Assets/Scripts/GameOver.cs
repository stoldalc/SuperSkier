using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField] Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        //finalScore = ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
