 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    [SerializeField]
    private Transform _positionA, _positionB;
    private bool _switching = false;





    void FixedUpdate()
    {   
        if (_switching == false){
            float step =  speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _positionB.position, step);
                if (transform.position == _positionB.position){
                    _switching = true;
                }
        }else{
            float step =  speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _positionA.position, step);
                if (transform.position == _positionA.position){
                    _switching = false;
                }
        }        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            other.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.tag == "Player"){
            other.transform.parent = null;
        }
    }



}
