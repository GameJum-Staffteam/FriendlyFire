using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public enum SCENES
{
    TITLE,
    GAME,
    RESULT,
}
namespace Scene
{
    static public class SceneManager
    {


        static public void SceneMove(SCENES NextScene)
        {

            FadeManager.instance.LoadScene((int)NextScene, 1.0f);

        }
    }
}