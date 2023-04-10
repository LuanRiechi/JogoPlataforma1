using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMegaman : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rbd;
    public float vel;
    public float pulo;
    private bool direita = true;
    private bool chao;
    // Start is called before the first frame update
    void Start()
    {
        pulo = 15000;
        vel = 6;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        chao = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        chao = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        if (direita && x<0 || !direita && x > 0)
        {
            transform.Rotate(new Vector2(0,180));
            direita = !direita;
        }

        if (x ==0)
        {
            anim.SetBool("movimento", false);
        }else
        {
            anim.SetBool("movimento", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && chao) 
        {

            rbd.AddForce(new Vector2(0,pulo));
        }


        
    }
}
