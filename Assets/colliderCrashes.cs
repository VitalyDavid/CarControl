using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderCrashes : MonoBehaviour
{
    public RCC_CarControllerV3 cc;
    public Terrain ter;
    public AK.Wwise.Event crashSound, longCrashPlay, longCrashStop;
    bool delay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AkSoundEngine.SetRTPCValue("RTPC_Speed", cc.speed, gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle" && !delay)
        {
            if(cc.speed > 90f)
            {
                AkSoundEngine.SetSwitch("CrashType", "Big", gameObject);
                crashSound.Post(gameObject);
            }
            if(cc.speed <= 90f && cc.speed >= 7f)
            {
                AkSoundEngine.SetSwitch("CrashType", "Small", gameObject);
                crashSound.Post(gameObject);
            }
            
            StartCoroutine(CrashDelay());
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            
            longCrashPlay.Post(gameObject);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            longCrashStop.Post(gameObject);
        }
    }

    IEnumerator CrashDelay()
    {
        delay = true;
        yield return new WaitForSeconds(0.5f);
        delay = false;
    }
}

