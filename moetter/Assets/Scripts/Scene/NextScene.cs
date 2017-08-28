using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Scene;

public class NextScene : MonoBehaviour
{

    [SerializeField]
    SCENES nextScene;

    public void mOnTap()
    {
        SceneManager.SceneMove(nextScene);
    }
}