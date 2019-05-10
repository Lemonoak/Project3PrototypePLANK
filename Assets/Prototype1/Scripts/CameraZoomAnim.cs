using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomAnim : MonoBehaviour
{
    Animator anim;
    /*[HideInInspector] */
    public bool isZoomed = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("playerInside", isZoomed);
    }
}
