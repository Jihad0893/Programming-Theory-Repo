using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public InputField nameInputfield;
    public Button startButton;

    private void Start()
    {
        //nameInputfield.name = xxx.getname();
    }

    //-------------------------------------------------------------------
    // Enter the game
    public void GameStart()
    {
        SceneManager.LoadScene((int)Config.SceneConfig.Main);
    }

}
