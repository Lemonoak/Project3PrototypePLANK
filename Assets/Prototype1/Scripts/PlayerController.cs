using UnityEngine;

[RequireComponent(typeof(InputHandler))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    InputHandler input;

    [Header("Movement")]
    [SerializeField]
    float speed = 5f;
    private Rigidbody rigidbody;

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
                Debug.Log(input.controllerID + " Pressed X");
            }
        }
    }

}
