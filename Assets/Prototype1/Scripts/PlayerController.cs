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
            Vector3 velocity = (moveDirection * 100 * speed * Time.deltaTime) + (Vector3.up * rigidbody.velocity.y);
            rigidbody.velocity = velocity;

            //Turn character
            if (moveDirection.sqrMagnitude > 0.0f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection, Vector3.up), rotationSpeed);
            }
        }
    }

    public float charge;    //t
    public float maxCharge;
    public float chargeIncrease = 2f;
    public float chargeDecrease = 5f;
    public float angleToStopAt = 90;
    public float angleToStartAt = -90;
    public bool isAttacking = false;

    void Fire()
    {
        if(input.ConnectedController)
        {
            if (Input.GetAxisRaw(input.Action) > 0)
            {
                charge = Mathf.Clamp01(charge + (Time.deltaTime * chargeIncrease));
                angleToStopAt = Mathf.Abs(angleToStopAt);
                angleToStartAt = -Mathf.Abs(angleToStartAt);
                maxCharge = charge;
            }
            else if(Input.GetAxisRaw(input.Action2) > 0)
            {
                charge = Mathf.Clamp01(charge + (Time.deltaTime * chargeIncrease));
                angleToStopAt = -Mathf.Abs(angleToStopAt);
                angleToStartAt = Mathf.Abs(angleToStartAt);
                maxCharge = charge;
            }
            else
            {
                isAttacking = charge > 0;
                charge = Mathf.Clamp01(charge - (Time.deltaTime * chargeDecrease));
            }
            batPivot.transform.localRotation = Quaternion.Euler(new Vector3(0, angleToStartAt + (charge * angleToStopAt), 0));
        }
    }

    //The function to get pushed
    public void GetPushed(Vector3 direction, float distanceMultiplier, float pushTime)
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
                GetPushed(gameObject.transform.forward, 6, 0.8f);
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