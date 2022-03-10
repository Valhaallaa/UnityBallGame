using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GoalScript : MonoBehaviour
{
    [SerializeField]
    int currentLevel;
    int maxLevel;
    [SerializeField]
    TextMeshProUGUI TimeUI;
    [SerializeField]
    TextMeshProUGUI BestTimeUI;
    float TimeV;
    
    int LevelComplete;
    float BestTime;



    void timer()
    {// has a timer running if the level has not been completed yet
        if (LevelComplete == 0)
        {
            TimeV = TimeV + Time.deltaTime;
            TimeUI.text = " " + TimeV.ToString("F1");
        }
        else { }
    }


     void OnCollisionEnter(Collision other)
    {
        // checks to see if the ball has collided with the goal object 
        if (other.gameObject.name.Contains("all"))
        {
            // used to see what level the player is up too completing
            if (maxLevel < currentLevel)
            {
                PlayerPrefs.SetInt("CurrentLevel", currentLevel);
               
            }
            LevelComplete = 1;
            Debug.Log("LevelEnd");
            // this section will overwrite the previous Playerpref for that besttime if it is shorter than what the time was upon completion, it will also do it if the bestTime is currently set too 0.
            if (BestTime > TimeV || BestTime == 0)
                {
                if (currentLevel == 1)
                {
                    PlayerPrefs.SetFloat("BestTime1", TimeV);
                    Debug.Log("SetBestLevel1");
                }
                if (currentLevel == 2)
                {
                    PlayerPrefs.SetFloat("BestTime2", TimeV);
                    Debug.Log("SetBestLevel2");
                }
                if (currentLevel == 3)
                {
                    PlayerPrefs.SetFloat("BestTime3", TimeV);
                    Debug.Log("SetBestLevel3");
                }
                if (currentLevel == 4)
                {
                    PlayerPrefs.SetFloat("BestTime4", TimeV);
                    Debug.Log("SetBestLevel4");
                }
            }
            SceneManager.LoadScene(0);
        }

    }

    void SetBest()
    {
        // this gets the BestTime playerpref for the leve so it can be set within the UI
        if (currentLevel == 1)
        {
            BestTime = PlayerPrefs.GetFloat("BestTime1");
            Debug.Log("SetBestLevel1");
        }
        if (currentLevel == 2)
        {
            BestTime = PlayerPrefs.GetFloat("BestTime2");
            Debug.Log("SetBestLevel2");
        }
        if (currentLevel == 3)
        {
            BestTime = PlayerPrefs.GetFloat("BestTime3");
            Debug.Log("SetBestLevel3");
        }
        if (currentLevel == 4)
        {
            BestTime = PlayerPrefs.GetFloat("BestTime4");
            Debug.Log("SetBestLevel4");
        }
        BestTimeUI.text = " " + BestTime.ToString("F1");
    }


    // Start is called before the first frame update
    void Start()
    {
        SetBest();
        //BestTime = PlayerPrefs.GetFloat("BestTime");
        LevelComplete = 0;
        maxLevel = PlayerPrefs.GetInt("CurrentLevel");

        //BestTimeUI.text = " " + PlayerPrefs.GetFloat("BestTime");
    }

    // Update is called once per frame
    void Update()
    {
        timer();
    }
}
