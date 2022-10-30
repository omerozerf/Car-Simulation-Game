using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed; //car speed
    [SerializeField] private float turnSpeed; // horizontal speed
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject lostScreen;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //to move horitontal axis with a - d
        verticalInput = Input.GetAxis("Vertical"); //to move vertical axis with w - s
        
        //this two lines change to car location  
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime); 
        transform.Rotate(Vector3.up* turnSpeed * horizontalInput * verticalInput * Time.deltaTime);

        if (transform.position.y < -4) { // show lose screen
            lostScreen.SetActive(true);
        }
        else if (transform.position.z >155) { //show win screen
            winScreen.SetActive(true);
        }
    }

    public void PlayAgain() //set to starting car's location and close win-lose screen
    {

        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(Vector3.zero);
        
        winScreen.SetActive(false);
        lostScreen.SetActive(false);

    }
}
