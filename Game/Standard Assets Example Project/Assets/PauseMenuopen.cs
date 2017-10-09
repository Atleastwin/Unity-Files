using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuopen : MonoBehaviour
{
    public Transform Menu;
    
    public void Menuopen(GameObject Menu)
    {
        Menu.SetActive(true);
        GamePause(0);
    }

    public void Menuclose(GameObject Menu)
    {
        Menu.SetActive(false);
        GamePause(1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuDisplay();
        }
    }

    void MenuDisplay()
    {
        if (Menu.gameObject.activeInHierarchy == false)
        {
            Menu.gameObject.SetActive(true);
            GamePause(0);

        }
        else
        {
            Menu.gameObject.SetActive(false);
            GamePause(1);
        }
    }

    void GamePause(int stop)
    {
        Time.timeScale = stop;
    }
}
