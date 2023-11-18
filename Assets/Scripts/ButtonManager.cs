using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TitleScreen, StoryScreen;
    void Start()
    {
        TitleScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        TitleScreen.SetActive(false);
        StoryScreen.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
    }
}
