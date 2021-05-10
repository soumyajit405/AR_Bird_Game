﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneWhenClicked : MonoBehaviour
{
  public void loadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
