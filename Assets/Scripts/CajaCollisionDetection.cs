using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement CajaMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        CajaMovementScript = GetComponent<CajaMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision col){
    if (col.gameObject.CompareTag("Piso")){
        CajaMovementScript.MoveBoxToRandomPosition();
    }
}
}

