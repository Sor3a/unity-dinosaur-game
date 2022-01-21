using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour
{
    public float speed =0f;

    private void FixedUpdate()
    {
        transform.Translate(transform.right * -1f * speed*Time.deltaTime);
    }
}
