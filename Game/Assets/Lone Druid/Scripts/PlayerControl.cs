using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Transform player;
    public Transform circle;
    public Transform outerCircle;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    private static bool PlayerExits = false;
    private Animator anim;
    private bool playerMoving;
    private Vector2 LastMove;
    private Vector2 PlayerFace;

    // Use this for initialization
    void Start () {
        if(!PlayerExits)
        {
            PlayerExits = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        playerMoving = false;

        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            circle.transform.position = pointA;
            outerCircle.transform.position = pointA;
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;

            playerMoving = true;
        }
        if(Input.GetMouseButton(0))
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStart = false;
        }
    }

    private void FixedUpdate()
    {
        if(touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);

            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y);
        }
        else
        {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }


        PlayerFace = pointB - pointA;
        LastMove = new Vector2(0, Input.mousePosition.y);

        anim.SetFloat("MoveX", PlayerFace.x);
        anim.SetFloat("MoveY", PlayerFace.y);
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", LastMove.x);
        anim.SetFloat("LastMoveY", LastMove.y);

    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
        
}