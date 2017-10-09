using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stucked : MonoBehaviour {
    private Vector3 startpos;
    public GameObject player;
    public GameObject Menu;
    
        private void Start()
    {
        startpos = player.transform.position;

    }

    public void Stucked()
    {
        player.transform.position = startpos;
        Menu.SetActive(false);
        Time.timeScale = 1;
    }
    
}
