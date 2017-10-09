using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metralla1 : MonoBehaviour {
    public GameObject bala;
    // Use this for initialization
    void Start() {
        StartCoroutine(TiempoDeDisparo());
    }

    // Update is called once per frame
    void Update() {

    }
    IEnumerator TiempoDeDisparo (){
        yield return new WaitForSeconds(2);
        StartCoroutine(TiempoDeDisparo());
        GameObject temp = GameObject.Instantiate(bala, transform.position, transform.rotation) ;
        Debug.Log(temp);
    }

}
