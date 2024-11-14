using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Загрзилась сцена" + sceneName);
        SceneManager.LoadScene(sceneName);
    }
        public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}

public class OpenLinks : MonoBehaviour
{
    public void OpenLink1()
    {
        Application.OpenURL("https://www.example1.com");
    }

    public void OpenLink2()
    {
        Application.OpenURL("https://www.example2.com");
    }

    public void OpenLink3()
    {
        Application.OpenURL("https://www.example3.com");
    }

    public void OpenLink4()
    {
        Application.OpenURL("https://www.example4.com");
    }
}