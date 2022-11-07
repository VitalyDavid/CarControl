using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brakes : MonoBehaviour
{
    public RCC_CarControllerV3 carControl;
    public AK.Wwise.Event brakesSound, shortDrift, handbrakeSound, handbrakeStop, backBrakeSound, backBrakeStop, brakesStop;
    public GameObject tires;
    float averageAngle;
    bool isDrifting, isBreaking, isHandBreaking = false;
    public LayerMask lm;
    private bool isGrounded;
    surfaceRaycast sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<surfaceRaycast>();
        isDrifting = false;
    }

    // Update is called once per frame
    /*void Update()
    {
        AkSoundEngine.SetRTPCValue("RTPC_Speed", carControl.speed, tires);

        if (carControl.driftingNow && !isDrifting || carControl.brakeInput > 0.5f || carControl.handbrakeInput > 0.5f)
        {
            StartCoroutine(AverangeDriftAngle());
            AkSoundEngine.SetRTPCValue("RTPC_DriftAmount", averageAngle, tires);
            isDrifting = true;
            brakesSound.Post(tires);
            Debug.Log("Brake");
        }
        if (!carControl.driftingNow && isDrifting)
        {
            brakesStop.Post(tires);
            isDrifting = false;     
        }
    }

    IEnumerator AverangeDriftAngle()
    {
        float first = carControl.driftAngle;
        yield return new WaitForSeconds(0.1f);
        float second = carControl.driftAngle;
        yield return new WaitForSeconds(0.1f);
        float third = carControl.driftAngle;
        averageAngle = (first + second + third) / 3;
    }*/

    private void Update()
    {
        AkSoundEngine.SetRTPCValue("RTPC_Speed", carControl.speed, tires);
        AkSoundEngine.SetRTPCValue("RTPC_DriftAmount", averageAngle, tires);
        AkSoundEngine.SetRTPCValue("RTPC_Direction", carControl.direction, tires);
        AkSoundEngine.SetState("Surface", sr.surfaceType);
        if (sr.isAirborne)
        {
            AkSoundEngine.SetState("IsAirborne", "True");
        }
        else AkSoundEngine.SetState("IsAirborne", "False");

        if (!sr.isAirborne)
        {
            if ((carControl.driftAngle > 0.2f && carControl.driftAngle < 0.3f) || (carControl.driftAngle < -0.2f && carControl.driftAngle > -0.3f))
            {
                shortDrift.Post(tires);
            }

            if (carControl.driftingNow && (carControl.driftAngle > 0.3f || carControl.driftAngle < -0.3f) && !isDrifting)
            {
                isDrifting = true;
                brakesSound.Post(tires);
            }
            if (!carControl.driftingNow && (carControl.driftAngle < 0.2f && carControl.driftAngle > -0.2f))
            {
                brakesStop.Post(tires);
                isDrifting = false;
            }
            if (carControl.brakeInput > 0.3f && !isBreaking)
            {
                backBrakeSound.Post(tires);
                isBreaking = true;
            }
            if ((carControl.brakeInput < 0.3f && carControl.brakeInput > -0.3f) && isBreaking)
            {
                backBrakeStop.Post(tires);
                isBreaking = false;
            }
            if (carControl.handbrakeInput > 0f && !isHandBreaking)
            {
                handbrakeSound.Post(tires);
                isHandBreaking = true;
            }
            if (carControl.handbrakeInput == 0f && isHandBreaking)
            {
                handbrakeStop.Post(tires);
                isHandBreaking = false;
            }
        }        
    }

}
