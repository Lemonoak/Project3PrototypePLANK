using UnityEngine;

[RequireComponent(typeof(InputHandler))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    InputHandler input;

    [Header("Movement")]
    [SerializeField]
    float speed = 5.0f;
    private Rigidbody rigidbody;
    [SerializeField]
    float hitRange = 10.0f;
    float force = 10.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        input = GetComponent<InputHandler>();
    }

    void FixedUpdate()
    {
        Moving();
        Fire();
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
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection, Vector3.up), 0.05f);
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
                RaycastHit hit;
                Vector3 origin = transform.position;
                Vector3 forwardDirection = transform.forward;
                Debug.DrawRay(origin, forwardDirection * hitRange, Color.blue, 3f);
                if(Physics.Raycast(origin, forwardDirection * hitRange, out hit))
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
                        hit.collider.gameObject.GetComponent<PlayerController>().GetPushed(forwardDirection);
                    }
                }
            }
        }
    }

    //The function to get pushed
    void GetPushed(Vector3 direction)
    {
        rigidbody.AddForce(new Vector3(direction.x * force, 10, direction.y * force), ForceMode.Impulse);
    }
}