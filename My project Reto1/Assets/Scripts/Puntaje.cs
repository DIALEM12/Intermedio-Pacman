using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;
    public GameObject CherryVariant;
    public GameObject MuroDestroy;
    
   




    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

    
    
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = puntos.ToString("0");

       

        if (puntos == 15)
        {
            Debug.Log("Cherry");
            CherryVariant.SetActive(true);
            Destroy(MuroDestroy);

        }

       

    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
       
    }
    
    



   

    
        
}

    

