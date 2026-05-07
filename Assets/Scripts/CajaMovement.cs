using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float caida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0 , -caida * Time.deltaTime, 0);
    }
}
