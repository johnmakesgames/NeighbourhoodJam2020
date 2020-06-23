using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainEngineComponent : TrainPieceComponent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(moveDirection);

        float moveAmount = 1.0f * Time.deltaTime;
        this.transform.position += moveDirection * moveAmount;
        //this.GetComponent<Rigidbody>().AddForce(moveAmount * moveDirection);
        //UpdateChildTrain(moveAmount);
    }
}
