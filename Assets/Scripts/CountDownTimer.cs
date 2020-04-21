using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountDownTimer : MonoBehaviour
{

    public float startTime = 10;
    public float currentTime = 0;

    [SerializeField] Text countDownText;

    public string GameOverScene;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;    
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString();
        print(currentTime);
        if(currentTime <= 1)
        {
            SceneManager.LoadScene(GameOverScene);
        }
    }
}
