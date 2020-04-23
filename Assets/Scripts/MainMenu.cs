using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string newGameScene;
    public string optionsScreen;

    public GameObject mainMenuTitle;
    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject quitButton;

    public GameObject optionsTitle;
    public GameObject optionsBackPanel;

    //public GameObject volumeSlider;
    public GameObject backButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        //Status of title
        mainMenuTitle.gameObject.SetActive(status);
        //Status of start button
        startButton.gameObject.SetActive(status);
        //Status of options button
        optionsButton.gameObject.SetActive(status);
        //Status of quit button
        quitButton.gameObject.SetActive(status);
    }

    void Options(bool status)
    {
        //Status of title
        optionsTitle.gameObject.SetActive(status);
        //Set status of options back panel
        optionsBackPanel.gameObject.SetActive(status);
        //Status of volume slider
        //volumeSlider.gameObject.SetActive(status);
        //Status of back button
        backButton.gameObject.SetActive(status);
    }
}
