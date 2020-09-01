using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacBehavor : MonoBehaviour
{
    private Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    public Click click;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();

        rb.velocity += new Vector2(0, 0);
        //click.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //Go Up
        {
            click.AttackSword();
        }

        if (Input.GetKey("w")) //Go Up
        {
            Up();
        }

        if (Input.GetKey("s")) //Go Down
        {
            Down();
        }

        if (Input.GetKey("d")) //Go Right
        {
            Right();
        }

        if (Input.GetKey("a")) //Go left
        {
            Left();
        }

        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            UpRight();
        }

        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            UpLeft();
        }

        if (Input.GetKey("s") && Input.GetKey("d"))
        {
            DownRight();
        }

        if (Input.GetKey("s") && Input.GetKey("a"))
        {
            DownLeft();
        }




        if (Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("d") || Input.GetKeyUp("a") || Input.GetKeyUp("space"))
        {
            //float Z = 140;
            rb.velocity = new Vector2(0, 0);
            //click.gameObject.SetActive(false);
            click.StopAttack();
        }

        
    }

    void UpRight()
    {
        rb.velocity = new Vector2(vitesse, vitesse);
    }
    void UpLeft()
    {
        rb.velocity = new Vector2(-1 * vitesse, vitesse);
    }
    void DownRight()
    {
        rb.velocity = new Vector2(vitesse, -1 * vitesse);
    }
    void DownLeft()
    {
        rb.velocity = new Vector2(-1*vitesse, -1 * vitesse);
    }
    void Up()
    {
        rb.velocity = new Vector2(0, vitesse);
    }
    void Down()
    {
        rb.velocity = new Vector2(0, vitesse*-1);
    }

    void Right()
    {
        rb.velocity = new Vector2(vitesse, 0);
    }

    void Left()
    {
        rb.velocity = new Vector2(vitesse * -1, 0);
    }


    public void AttackSword()
    {
        //this.gameObject.SetActive(true);
        animator.SetBool("attack", true);

        new WaitForSeconds(5);
        //animator.SetBool("attack", false);
    }

    public void StopAttack()
    {
        animator.SetBool("attack", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
    }  
    
    
    
    
    
    /*void Jump()
    {
        rb.velocity = new Vector2(0, maxJump);
    }*/

    /*void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground")){
            isGrounded = false;
        }
    }*/
}
