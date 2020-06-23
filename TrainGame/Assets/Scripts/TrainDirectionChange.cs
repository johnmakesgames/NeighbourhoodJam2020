using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainDirectionChange : MonoBehaviour
{
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = this.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<TrainPieceComponent>())
        {
            var trainPiece = other.gameObject.GetComponentInParent<TrainPieceComponent>();
            trainPiece.moveDirection = direction;
        }
    }
}
