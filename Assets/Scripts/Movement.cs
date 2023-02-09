using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator horseAnim;

    //[SerializeField] Transform playerLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        
    }

    void movement()
    {
        float moveAmount = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(moveAmount, 0, 0);
        if(moveAmount != 0)
        {
            horseAnim.SetBool("isMoving", true);
        }
        else
        {
            horseAnim.SetBool("isMoving", false);
        }
    }
    
}
