using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Rigidbody2D rb;
    //public float moveSpeed = 5;
    //Vector2 moveDirection;

    bool podeMovimentar = false;
    public Animator anim;
    public float speed;


    void Update()
    {
        if (!podeMovimentar)
        {
            if (Input.GetKey(KeyCode.E))
            {
               
                podeMovimentar = true;
                //Debug.Log("Clicou para habilitar controle");
            }
            else
            {
                return;
            }
        }

        ProcessInputs();

    }

    // Update is called once per frame
    //void FixedUpdate()
    //{
    //    Move();
    //}


    void ProcessInputs()
    {
        Vector3 movemnet = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        anim.SetFloat("Horizontal", movemnet.x * -1);
        anim.SetFloat("Vertical", movemnet.y);
        anim.SetFloat("Horizontal", movemnet.x * -1);
        anim.SetFloat("Speed", movemnet.magnitude);

        transform.position = transform.position + movemnet * speed * Time.deltaTime;
    }
   


}

