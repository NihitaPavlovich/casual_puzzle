using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
