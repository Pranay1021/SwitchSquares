using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicbutton : MonoBehaviour

{
    [SerializeField] Image on;
    [SerializeField] Image off;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            load();
        }
        else
        {
            load();
        }
    }
    void Update()
    {
        Updatebuttonicon();
        AudioListener.pause = muted;
    }

    public void Onbutton()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        save();

    }

    private void Updatebuttonicon()
    {
        if (muted == false)
        {
            on.enabled = true;
            off.enabled = false;
        }
        else
        {
            off.enabled = true;
            on.enabled = true;
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }


}
