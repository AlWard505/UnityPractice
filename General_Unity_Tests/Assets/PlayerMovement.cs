using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController2D Controller;
    //[SerializeField] player Player;
    public float runspeed = 40f;
    public int PlayerLives = 3;
    //public GetComponent.boxCollider2D Collision2D;
    float horizontalMove = 0f;

    bool jump = false;
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    void FixedUpdate()
    {
        //moves the character
        Controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void death()
    {
        if (PlayerLives < 1)
        {
            //GetComponent < BoxCollider2D > "spikes";
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("kinda");
        if (other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (other.gameObject.tag == "bullet")
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
 