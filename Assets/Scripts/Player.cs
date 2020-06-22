using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    
    public float speed;
    private float input;
    public int health;
    public Text healthDisplay;

    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        healthDisplay.text = health.ToString();
    }

    void Update() {

        //0 means he's stationary
        if (input != 0) {
            anim.SetBool("isRunning", true);
        }
        else {
            anim.SetBool("isRunning", false);
        }

        //flip him 180 degrees, 1 is all the way to the right, -1 is left
        if (input > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //user input
        input = Input.GetAxisRaw("Horizontal");
        // print(input);

        //move player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount) {
        health -= damageAmount;
        healthDisplay.text = health.ToString();
        if (health <= 0){
            print("player died");
            Destroy(gameObject);
        }
    }
}
