using System.Collections;
using UnityEngine;

[RequireComponent(typeof(InputHandler))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    InputHandler input;

    [Header("Movement")]
    private Rigidbody rigidbody;
    private BoxCollider paddle;

    [SerializeField]
    float speed = 5.0f;
    [SerializeField]
    float hitRange = 5.0f;
    [SerializeField]
    int hitWidth = 9;
    [SerializeField]
    float pushForce = 10.0f;
    [SerializeField]
    float pushForceZ = 10.0f;
    [SerializeField]
    float rotationSpeed = 0.2f;
    [SerializeField]
    float pushDelay = 0.1f;
    public float shakeTime = 1.0f;
    public float respawnTimer = 1.0f;

    private Camera mainCamera;
    public BatSwingAnimation batPivot;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        input = GetComponent<InputHandler>();
        mainCamera = Camera.main;
        batPivot = GetComponentInChildren<BatSwingAnimation>();
        paddle = GetComponentInChildren<BoxCollider>();
    }

    float lerpTime;
    Vector3 lerpTarget;
    private void Update()
    {
        if (lerpTime > 0)
        {
            lerpTime -= Time.deltaTime / 0.5f;
            transform.position = Vector3.Lerp(transform.position, lerpTarget, Mathf.Clamp01(1 - lerpTime));
        }
    }

    void FixedUpdate()
    {
        Moving();
        Fire();
        Dash();
    }

    void Moving()
    {
        if (input.ConnectedController)
        {
            //Move
            Vector3 moveDirection = new Vector3(Input.GetAxisRaw(input.Horizontal), 0.0f, -Input.GetAxisRaw(input.Vertical));
            rigidbody.velocity = moveDirection * 100 * speed * Time.deltaTime;

            //Turn character
            if(moveDirection.sqrMagnitude > 0.0f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection, Vector3.up), rotationSpeed);
            }
        }
    }

    void Fire()
    {
        if(input.ConnectedController)
        {
            if(Input.GetButtonDown(input.Action))
            {
                //Debug.Log(input.controllerID + " Pressed X");

                if(batPivot)
                {
                    if(batPivot.isAttacking == false)
                    {
                        batPivot.isAttacking = true;
                    }
                }

                //Vector3 forwardDirection = Quaternion.Euler(0, angle, 0) * transform.forward;
                RaycastHit hit;
                Vector3 origin = transform.position;
                int angle = -50;
                   
                

                /*
                for (int i = 0; i < hitWidth; i++)
                {
                    Vector3 forwardDirection = Quaternion.Euler(0, angle, 0) * transform.forward;
                    angle += 20;                   

                    
                    Debug.DrawRay(origin, forwardDirection * hitRange, Color.blue, 3f);
                    if (Physics.Raycast(origin, forwardDirection, out hit, hitRange))
                    {
                        //Debug.Log(hit);
                        //this pushes a box
                        if(hit.collider.tag == "Box")
                        {
                            hit.collider.gameObject.GetComponent<GetPushed>().AddForce(forwardDirection);
                        }
                        //This pushed the player
                        if (hit.collider.tag == "Player" && hit.collider != this)
                        {
                            Time.timeScale = 0;
                            StartCoroutine(DelayedPush(hit, forwardDirection));
                        }
                    }
                }
                */
            }
        }
    }

    //The function to get pushed
    public void GetPushed(Vector3 direction, int distanceMultiplier, float pushTime)
    {
        lerpTime = pushTime;
        lerpTarget = transform.position + (direction * distanceMultiplier);
    }

    void Dash()
    {
        if (input.ConnectedController)
        {
            if (Input.GetButtonDown(input.Jump))
            {
                Debug.Log("Dash");
                GetPushed(transform.forward, 8, 0.8f);
            }
        }
    }

    public IEnumerator DelayedPush(/*RaycastHit hit,*/ Vector3 forwardDirection)
    {
        yield return new WaitForSecondsRealtime(pushDelay);
        Time.timeScale = 1;
        //hit.collider.gameObject.GetComponent<PlayerController>().GetPushed(forwardDirection, 10, 1);
        mainCamera.GetComponent<CameraShake>().shakeDuration = shakeTime;
        StopCoroutine(DelayedPush(/*hit,*/ forwardDirection));
    }


}