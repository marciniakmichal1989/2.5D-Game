using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private float _speed = 2f; 
    [SerializeField] private float _gravitry = 1f; 
    [SerializeField] private float _jumpHeight = 15.0f; 
    private float _yVelocity;
    private bool _canDoubleJump = false;


    void Start()
    {
        _controller = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") ;
        Vector3 direction = new Vector3(horizontalInput,0,0);
        Vector3 velocity = direction * _speed;

        if (_controller.isGrounded == true){
            if (Input.GetKeyDown(KeyCode.Space)){
                _yVelocity = _jumpHeight;
                _canDoubleJump = true;
            }

        }else{
            if(Input.GetKeyDown(KeyCode.Space)){
                if (_canDoubleJump == true){
                    _yVelocity += _jumpHeight * 2;
                    _canDoubleJump = false;
                }
                
            }
            _yVelocity -= _gravitry;
        }

        velocity.y = _yVelocity; 

        _controller.Move(velocity * Time.deltaTime) ;
    }
}
