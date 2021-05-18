using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public Rigidbody2D rb;
    //public float moveSpeed = 5;
    //Vector2 moveDirection;

    bool podeMovimentar = false;
    public Animator anim;
    public float speed;
    //public Text texto;
    [SerializeField] Text text;

    private void Start()
    {
       
    }
    void Update()
    {
        if (!podeMovimentar)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                podeMovimentar = true;
               
                
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

