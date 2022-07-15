using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilador : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f;
    void Start()
    {
        startingPosition = transform.position;
        
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) {return;} 
        float cycles = Time.time / period; // continua creciendo con el tiempo
        
        const float tau = Mathf.PI * 2; // valor constante de 6.283
        float rawSinWave = Mathf.Sin(cycles * tau); // de -1 a 1

        movementFactor = (rawSinWave +1f) / 2f; // recalculado para ir de 0 a 1
        
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
