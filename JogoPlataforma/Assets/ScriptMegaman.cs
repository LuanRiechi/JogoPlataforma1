using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMegaman : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rbd;
    public float vel;
    private bool direita = true;
    // Start is called before the first frame update
    void Start()
    {
        vel = 6;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

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


        
    }
}
