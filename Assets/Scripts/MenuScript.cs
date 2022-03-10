using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject MenuObj;

    [SerializeField]
    private GameObject CreditsObj;

    [SerializeField]
    private GameObject LevelObj;

    private int currentlevel;

    float BestTime;

    // this script is used for the buttons on the menu, they activate and deactive objects when a button is pressed, as well as changing the level scenes

    public void ToggleCredits()
    {
        if (CreditsObj.activeInHierarchy)
        {
            CreditsObj.SetActive(false);
            MenuObj.SetActive(true);
        }
        else
        {
            CreditsObj.SetActive(true);
            MenuObj.SetActive(false);
        }
        Debug.Log(currentlevel);
    }
    public void ToggleLevelSel()
    {
        if (LevelObj.activeInHierarchy)
        {
            LevelObj.SetActive(false);
            MenuObj.SetActive(true);
        }
        else
        {
            LevelObj.SetActive(true);
            MenuObj.SetActive(false);
        }
    }

    public void ContinueLevel()
    {
        if (currentlevel == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(currentlevel + 1);
        }
    }
    public void MenuSelect()
    {

        SceneManager.LoadScene(0);
    }
    public void Level1Select()
    {

        SceneManager.LoadScene(1);
    }
    public void Level2Select()
    {
        if (currentlevel >= 1) {
            SceneManager.LoadScene(2); }
        }
    public void Level3Select()
    {
        if (currentlevel >= 2)
        {
            SceneManager.LoadScene(3);
        }

    }
    public void Level4Select()
    {
        if (currentlevel >= 3)
        {
            SceneManager.LoadScene(4);
        }

    }
    public void ClearProgress()
    {
        currentlevel = 0;
        BestTime = 0;
        PlayerPrefs.SetInt("CurrentLevel", currentlevel);
        PlayerPrefs.SetFloat("BestTime1",BestTime);
        PlayerPrefs.SetFloat("BestTime2", BestTime);
        PlayerPrefs.SetFloat("BestTime3", BestTime);
    }
    public void Quit()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentlevel = PlayerPrefs.GetInt("CurrentLevel");
    }
}
