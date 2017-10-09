using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class Dieres : MonoBehaviour
{
    public GameObject Player;
    public Text tvidas;
    public GameObject Final_mess_check;
    public Text Final_mess;
    public string message;

    private Vector3 startpos;
    private int vidas;

    // Use this for initialization
    void Start()
    {
        startpos = transform.position;
        vidas = 3;
        Final_mess_check.SetActive(false);
        Final_mess.text = message;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Die"))
        {
            transform.position = startpos;
            vidas -= 1;
            SettoString();

        }

    }

    // Update is called once per frame
    void Update()
    {
        SettoString();
        if (vidas == 0)
        {
            Player.SetActive(false);
            Final_mess_check.SetActive(true);
       
        }
    }

    private void SettoString()
    {
       tvidas.text = vidas.ToString();
    }
   
}
