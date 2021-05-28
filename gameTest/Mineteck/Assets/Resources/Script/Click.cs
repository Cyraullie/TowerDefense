using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    Animator animator;
    


    //public int damage;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackSword()
    {
        //this.gameObject.SetActive(true);
        animator.SetBool("idle", true);

        new WaitForSeconds(5);
        //animator.SetBool("attack", false);
    }

    public void StopAttack()
    {
        animator.SetBool("idle", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
    }

    /*private void OnMouseDown()
    {
        Debug.Log("Clic sur " + this.gameObject.name);
    }*/

}
