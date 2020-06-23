using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainPieceComponent : MonoBehaviour
{
    public TrainPieceComponent childTrainPiece = null;
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(moveDirection);
    }

    protected virtual void UpdateChildTrain(float moveAmount)
    {
        if (childTrainPiece != null)
        {
            var trainComp = childTrainPiece.GetComponent<TrainPieceComponent>();
            trainComp.AddForceToTrain(moveAmount);
        }
    }

    internal void AddForceToTrain(float moveAmount)
    {
        this.transform.position += moveAmount * moveDirection;
        UpdateChildTrain(moveAmount);
    }
}
