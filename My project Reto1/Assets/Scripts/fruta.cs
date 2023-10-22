using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruta : MonoBehaviour
{
    
    //public GameObject efecto;
    public float cantidadPuntos;
    public Puntaje puntaje;

    private void OnTriggerEnter(Collider other){

        if(other.CompareTag("Player"))
        {
            //Instantiate(efecto, transform.position, Quaternion.identity);
            puntaje.SumarPuntos(cantidadPuntos);
            //AudioManager.Instance.PlaySFX("Coin");
            Destroy(gameObject);
            
        }
    }
}
