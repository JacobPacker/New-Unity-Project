using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        explode();
    }
    void explode()
    {
        if (Input.GetKeyDown("s"))
        {
            anim.SetBool("Explode", true);
        }
        else
        {
            anim.SetBool("Explode", false);
        }
    }
}
