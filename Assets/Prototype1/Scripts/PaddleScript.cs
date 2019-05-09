using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public PlayerController player;
    Vector3 forwardDirection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && player.isAttacking)
        {
            Debug.Log("Paddle yo");
            forwardDirection = player.gameObject.transform.forward;
            other.gameObject.GetComponent<PlayerController>().GetPushed(forwardDirection, (6 * player.maxCharge), 1);
            Debug.Log(10 * player.maxCharge);
            Time.timeScale = 0;
            player.StartCoroutine(player.DelayedPush(forwardDirection));
        }
    }
}
