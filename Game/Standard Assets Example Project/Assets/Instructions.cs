using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public Transform Menu;
    public Transform Instructions_Menu;
    public Transform Credits_Menu;

    public void InstructionsMenu(GameObject Menu)
    {
        MenuDisplay();

    }

    void MenuDisplay()
    {
        if (Menu.gameObject.activeInHierarchy == false)
        {
            Menu.gameObject.SetActive(true);
            Instructions_Menu.gameObject.SetActive(false);
            Credits_Menu.gameObject.SetActive(false);


        }
        else
        {
            Menu.gameObject.SetActive(false);
            Instructions_Menu.gameObject.SetActive(true);
            Credits_Menu.gameObject.SetActive(false);

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuDisplay();
        }
    }


}
