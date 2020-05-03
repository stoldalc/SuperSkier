using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public GameObject highscoreEntry;

    [SerializeField] Text finalScore;
    // Start is called before the first frame update
    void Start()
    {

        if (HighscoreTable.HighscoreCheck(SkierEntity.score))
        {
            HighscoreEnterScreen();
        }
    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Final score: " + SkierEntity.score.ToString();

    }
    public void QuitButton()
    {
        Application.Quit();
    }

    private string HighscoreEnterScreen()
    {
        highscoreEntry.gameObject.SetActive(true);
        /*Does all the game object activation/deactvation handeling h
         * 
         * This will need a text field
         * text input needs to be limited to 3 chars
         * this will reutn turn the name string
         */

        return ""; 
    }



}
