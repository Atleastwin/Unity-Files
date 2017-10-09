using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoController : MonoBehaviour {
    float tiempo;
	// Use this for initialization
	void Start () {
        tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
        tiempo = tiempo +Time.deltaTime;
        Debug.Log(tiempo);
	}
}
