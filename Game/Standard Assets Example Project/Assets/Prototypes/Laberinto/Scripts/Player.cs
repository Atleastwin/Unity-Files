using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float Fuerza = 10;
    public Rigidbody rb;
    public Camera camara;
    public Text monedasTxt;
    public Button reiniciarBtn;
    private int monedas;
    private Vector3 camaraPosIni;
	// Use this for initialization
	void Start () {
        //obtengo el rb del commponente *opcion b
        //rb = GetComponent<Rigidbody>();
        camaraPosIni = camara.transform.position;
        monedas = 0;
        reiniciarBtn.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(h,0.5f,v);
        rb.AddForce(vector*Fuerza*Time.deltaTime);

        //
        camara.transform.position = this.transform.position + camaraPosIni;
	}
    private void OnTriggerEnter(Collider other)
    {
        //
        //Destroy(other.gameObject);
        if (other.gameObject.tag == "Moneda")
        {
            
            other.gameObject.SetActive(false);
            monedas++;
            monedasTxt.text = "Monedas: " + monedas.ToString();
            if (monedas >= 7)
            {
                monedasTxt.text = monedasTxt.text + " Ganaste!!!!!";
                reiniciarBtn.gameObject.SetActive(true);
            }
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Basico");
    }

}
