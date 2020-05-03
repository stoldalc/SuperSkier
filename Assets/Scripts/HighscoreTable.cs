using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{

    public Transform entryContainter;
    public Transform entryTemplate;


    private List<Transform> highscoreEntryTransformList;

    // Start is called before the first frame update
    private void Awake()
    {
        //entryContainter = transform.Find("HighscoreEntryContainer");
        //entryTemplate = transform.Find("HighscoreEnteryTemplate");

        entryTemplate.gameObject.SetActive(false);


        AddHighscoreEntry(10000, "TST");

        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        if (highscores == null)
        {
            // There's no stored table, initialize
            Debug.Log("Initializing table with default values...");
            AddHighscoreEntry(999999, "CWS");
            
            // Reload
            jsonString = PlayerPrefs.GetString("highscoreTable");
            highscores = JsonUtility.FromJson<Highscores>(jsonString);
        }

        for (int i = 0; i <  highscores.highscoreEntryList.Count; i++)
        {
            for(int j = i; j < highscores.highscoreEntryList.Count; j++)
            {
                if(highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    HighscoreEntry buffer = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = buffer;
                }
            }
        }


        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainter, highscoreEntryTransformList);
        }

    }

    private void CreateHighscoreEntryTransform(HighscoreEntry higscoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 15f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count+1;


        entryTransform.Find("PosText").GetComponent<Text>().text = rank.ToString();
        entryTransform.Find("ScoreText").GetComponent<Text>().text = higscoreEntry.score.ToString();
        entryTransform.Find("NameText").GetComponent<Text>().text = higscoreEntry.name;

        transformList.Add(entryTransform);
    }

    private void AddHighscoreEntry(int score, string name)
    {
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score, name = name };

        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        highscores.highscoreEntryList.Add(highscoreEntry);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }



    private class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;
    }


    static public bool  HighscoreCheck(int score)
    {
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            if(score > highscores.highscoreEntryList[i].score)
            {
                //#NSAA
                return true;
            }
        }


        return false;
    }



    [System.Serializable]
    private class HighscoreEntry
    {
        public int score;
        public string name;

    }


}
