using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMvt : MonoBehaviour
{

    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) <=0.05f)
        {
            rb.velocity = new Vector2(0, jumpForce);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            SceneManager.LoadScene(0);
        }
    }
}
