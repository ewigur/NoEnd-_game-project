using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _scenManager : MonoBehaviour
{

    public void _loadScene(string SceneName)
    {


        SceneManager.LoadScene(SceneName);
    }

}
