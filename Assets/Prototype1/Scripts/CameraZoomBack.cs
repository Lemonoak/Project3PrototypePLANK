using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomBack : MonoBehaviour
{

    public CameraZoomAnim mainCamera;

    public bool playerInside = false;
    void Start()
    {
        mainCamera = Camera.main.GetComponent<CameraZoomAnim>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInside = true;
            mainCamera.isZoomed = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInside = true;
            mainCamera.isZoomed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInside = false;
            mainCamera.isZoomed = false;
        }
    }

}
