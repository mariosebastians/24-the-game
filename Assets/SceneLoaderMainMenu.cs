using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderMainMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("mainmenuScene");
    }
}
