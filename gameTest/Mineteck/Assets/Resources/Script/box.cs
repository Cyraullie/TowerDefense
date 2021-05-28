using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public int life;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(life);
        life--;

        if(life == 0)
        {
            spriteRenderer.enabled = false;
            boxCollider2.enabled = false;
        }



        
    }


}
