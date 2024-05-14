using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBrick : MonoBehaviour
{

    public float speed=5f;
    public float moveDistance=5f;

    public bool moveRight=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight){
            transform.Translate(Vector2.right*speed*Time.deltaTime);
        }
        else{
            transform.Translate(Vector2.left*speed*Time.deltaTime);
        }
        if(transform.position.x>=moveDistance){
            moveRight=false;
        }
        else if(transform.position.x<=-moveDistance){
            moveRight=true;
        }
    }
}
