using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class Player_Bird : MonoBehaviour
{
    

    [SerializeField] private GameObject Bird;
    [SerializeField] private float moveSpeed = 1f;

    [SerializeField] private int score = 0;
    [SerializeField] private GameObject scoreNumber;
    [SerializeField] private GameObject flappuSpriteSheet;

    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject pipeSpawner;
    [SerializeField] private GameObject pipePrefab;

    private Animator animator;


    private Vector2 moveDir = Vector2.zero;
    private Vector3 moveDir3 = Vector3.zero;
    
    private Rigidbody2D rb;

   
    private void Start()
    {
        rb = Bird.GetComponent<Rigidbody2D>();
        animator = flappuSpriteSheet.GetComponent<Animator>();
        Debug.Log("string 2");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            animator.SetTrigger("Jump");
            
        }

        if (Input.touchCount != 0)
        {
            Jump();
            animator.SetTrigger("Jump");
        }

        if (transform.position.y < -5.7f || transform.position.y > 5.7f)
        {
            GameOver();
        }

    }

    private void Jump()
    {
        rb.velocity = Vector2.up * moveSpeed;
        
        /*moveDir.y = moveSpeed;
        //moveDir3 = new Vector3(moveDir.x, moveDir.y, 0f);
        //rb.velocity += moveDir * Time.deltaTime;
        rb.AddForce(moveDir);*/


    }

    public void AddScore()
    {
        score++;
        scoreNumber.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        gameOver.SetActive(true);
        rb.bodyType = RigidbodyType2D.Static;
        pipeSpawner.SetActive(false);
        Pipe[] pipes = FindObjectsOfType<Pipe>();

        foreach (Pipe pipe in pipes)
        {
            pipe.enabled = false;
        }
    }

    
}
