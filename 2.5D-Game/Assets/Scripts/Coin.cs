using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
      GameObject _player;
    
    void Start()
    {
        
    }


    void Update()
    {
              
        
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            Destroy(this.gameObject);

            Player _player = other.GetComponent<Player>();

            if (_player == null){
                Debug.Log("In Coin _player is null");
            }else{
                _player.AddCoins();
            }
            
        }
        

    }
}