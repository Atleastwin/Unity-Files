using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Endmessage : MonoBehaviour {
    public GameObject Player;  
    public GameObject mensajecontador;
    public GameObject contador;
    public GameObject Final_mess_check;
    public Text Final_mess;
    public string message;



    // Use this for initialization
    void Start () {
        Final_mess_check.SetActive(false);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
            {
            Player.SetActive(false);
            Final_mess.text = message;
            mensajecontador.SetActive(false);
            contador.SetActive(false);
            Final_mess_check.SetActive(true);
        }    
    }

    // Update is called once per frame
    void Update () {
		
	}
}
