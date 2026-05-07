using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float caida;
    float initialYValue;
    // Start is called before the first frame update
    void Start()
    {
        initialYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0 , -caida * Time.deltaTime, 0);
    }

    public void MoveBoxToRandomPosition(){
        //PARA PROBAR SOLO LO HAGO SUBIR
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;
    }
}
