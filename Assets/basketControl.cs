using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basketControl : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        //Vector2 moveDirection= new Vector2(0)
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, 0.0f);
        rb.velocity = moveDirection * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            SceneManager.LoadScene("Game");
            
        }
        else if (collision.transform.tag == "Coin")
        {
            
            Debug.Log("point");
        }
    }
}
