using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene_Manager : MonoBehaviour
{
    
    public string levelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }


  public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1;
    }
    
   
    public void Level_Main_menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }


    public void Ad_level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Skip_Ad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Pause_menu()
    {
        Time.timeScale = 0; 
    }
    public void Resume_game()
    {
        Time.timeScale = 1;
    }
}

