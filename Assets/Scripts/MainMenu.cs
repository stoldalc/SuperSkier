using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string newGameScene;
    public string optionsScreen;


    //Main menu container
    public GameObject mainMenuContainer;
    //Options container
    public GameObject optionsContainer;




    //Big dumb dumb at the keyboard forgot about using gameobjs as containers
    //But im keeping them just incase :)
    /*
    //Main menu 
    public GameObject mainMenuTitle;
    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject quitButton;
    public GameObject highscoreTable;

    //Options
    public GameObject optionsTitle;
    public GameObject optionsBackPanel;

    public GameObject volumeSlider;
    public GameObject volumeTitle;
    
    

    //public GameObject volumeSlider;
    public GameObject backButton;
    */

    public AudioSource audioSrc;
    public float musicVolume = .123f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
        
    }

    public void QuitGamePreseed()
    {
        Application.Quit();
    }

    public void OptionsPressed()
    {
        //SceneManager.LoadScene(optionsScreen);
        Options(true);
        MainMenuSwitch(false);
    }

    public void BackPressed()
    {
        MainMenuSwitch(true);
        Options(false);
    }
    void MainMenuSwitch(bool status)
    {

        mainMenuContainer.gameObject.SetActive(status);

        /*
        //Status of title
        mainMenuTitle.gameObject.SetActive(status);
        //Status of start button
        startButton.gameObject.SetActive(status);
        //Status of options button
        optionsButton.gameObject.SetActive(status);
        //Status of quit button
        quitButton.gameObject.SetActive(status);
        //Status of highscore Table
        highscoreTable.gameObject.SetActive(status);
        */

    }

    void Options(bool status)
    {

        optionsContainer.gameObject.SetActive(status);

        /*
        //Status of title
        optionsTitle.gameObject.SetActive(status);
        //Set status of options back panel
        optionsBackPanel.gameObject.SetActive(status);
        //Status of volume slider
        volumeSlider.gameObject.SetActive(status);
        //Status of back button
        backButton.gameObject.SetActive(status);
        //Status of volume title
        volumeTitle.gameObject.SetActive(status);
        */

    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
