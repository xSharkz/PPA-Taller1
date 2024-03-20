using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre_Apertura : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            animator.SetBool("esAbierto", true);

        }
    }
}
