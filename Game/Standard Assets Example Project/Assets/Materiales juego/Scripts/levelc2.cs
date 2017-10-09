using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelc2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal")) { SceneManager.LoadScene("Nivel2"); }



    }
    // Update is called once per frame
    void Update()
    {

    }
}
