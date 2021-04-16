using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{
    public float ratateSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up *ratateSpeed *Time.deltaTime,Space.World);
    }
    private void OnTriggerEnter(Collider other) 
    {
    if(other.name == "Player")
    {
        PlayerBall player= other.GetComponent<PlayerBall>();
        player.itemCount++; 
        gameObject.SetActive(false);
        
    }    
    }
}
