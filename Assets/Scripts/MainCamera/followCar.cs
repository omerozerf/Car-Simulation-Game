using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCar : MonoBehaviour
{
    [SerializeField] private GameObject Car; // object added to select to follow the car
    [SerializeField] private Vector3 offset; //add vector to change camera location
    


    void Update() 
    {
        transform.position = Car.transform.position + offset; // change for camera location


    }
}
