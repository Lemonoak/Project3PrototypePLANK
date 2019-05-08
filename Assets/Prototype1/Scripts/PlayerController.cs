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
    public GameObject batPivot;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        input = GetComponent<InputHandler>();
        mainCamera = Camera.main;
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

    private void OnDisable()
    {
        lerpTime = 0;
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

    public float charge;    //t
    public float chargeIncrease = 2f;
    public float chargeDecrease = 5f;
    public float angleToStopAt = 90;
    void Fire()
    {
        if(input.ConnectedController)
        {
            if (Input.GetButton(input.Action))
            {
                charge = Mathf.Clamp01(charge + (Time.deltaTime * chargeIncrease));
            }
            else
            {
                charge = Mathf.Clamp01(charge - (Time.deltaTime * chargeDecrease));
            }
            batPivot.transform.localRotation = Quaternion.Euler(new Vector3(0, charge * angleToStopAt, 0));
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
                //Debug.Log("Dash");
                GetPushed(gameObject.transform.forward, 8, 0.8f);
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