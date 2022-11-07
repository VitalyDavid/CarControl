using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mallReverb : MonoBehaviour
{

    private void Start()
    {
        AkSoundEngine.SetState("Mall", "Outside");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AkSoundEngine.SetState("Mall", "Inside");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            AkSoundEngine.SetState("Mall", "Outside");
        }
    }
}
