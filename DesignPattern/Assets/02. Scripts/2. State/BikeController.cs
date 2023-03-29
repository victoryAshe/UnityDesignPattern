using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public float maxSpeed = 2.0f;
    public float turnDistance = 2.0f;

    public float CurrentSpeed { get; set; }

    public CapsuleDirection2D CuttentTurnDirection { get; private set; }

    private IBikeState _startState, _stopState, _turnState;

    private BikeStateContext _bikeStateContext;

    void Start()
    {
        _bikeStateContext = new BikeStateContext(this);
    }

    void Update()
    {
        
    }
}
