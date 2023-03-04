using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;
    public Text text;
    public Text highscoretext;
    private float highscore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
       highscore= PlayerPrefs.GetFloat("highscore");
        Scoremanager.instance.ChangeScore(0);
    }

    public void ChangeScore(int pointscollect)
    {
        score += pointscollect;
        text.text = "Total Score : " + score.ToString();
        highscoretext.text = ("Your best : ") + ((int)highscore).ToString();
        if (score > highscore)
        {
            PlayerPrefs.SetFloat("highscore", score);
        }
    }
}
