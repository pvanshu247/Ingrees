using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;

    public GameObject ContinueButton;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("CurrentLevel"))
        {
            if(PlayerPrefs.GetString("CurrentLevel") == "")
            {
                ContinueButton.SetActive(false);
            }
        }else
        {
            ContinueButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("CurrentLevel"));
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(firstLevel);

        PlayerPrefs.SetString("CurrentLevel", "");

        PlayerPrefs.SetString(firstLevel + "cp", "");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game !");
    }
}
