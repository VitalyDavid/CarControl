using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumpSound : MonoBehaviour
{
    public AK.Wwise.Event bumpEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bumpEvent.Post(gameObject);
            Debug.Log("collide");
        }
    }
}
