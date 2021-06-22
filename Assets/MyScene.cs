using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MyScene : MonoBehaviour
{
    public void LoadAScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
