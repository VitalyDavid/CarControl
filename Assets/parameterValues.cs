using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parameterValues : MonoBehaviour
{
    public RCC_CarControllerV3 carControl;
    private RCC_CarControllerV3.IndicatorsOn indicatorsOn;
    public RCC_Light lightSource;
    public RCC_Exhaust rccExhaust;
    public AK.Wwise.Event engine, exhaust;
    public AK.Wwise.Event NOS;
    public AK.Wwise.Event accelEngine, accelExhaust;
    public AK.Wwise.Event gearShiftUp, gearShiftDown;
    public AK.Wwise.Event indicator, indicatorStop;
    public GameObject exhaustObject;
    public GameObject engineObject;
    public LensFlare lfBrightness;
    private bool NOSplaying;
    public bool changeGear, changed;
    private int currentGear, previousGear;
    private bool accelCor;
    public bool lightIsOn, lighStopped;
    float nosValue;


    // Start is called before the first frame update
    void Start()
    {
        carControl = gameObject.GetComponent<RCC_CarControllerV3>();
        exhaust.Post(exhaustObject);
        engine.Post(engineObject);
        lighStopped = true;
    }

    // Update is called once per frame
    void Update()
    {
        AkSoundEngine.SetRTPCValue("RTPC_RPM", carControl.engineRPM, exhaustObject);
        AkSoundEngine.SetRTPCValue("RTPC_RPM", carControl.engineRPM, engineObject);
        if (!carControl.NGear) AkSoundEngine.SetRTPCValue("RTPC_Load", carControl._gasInput, exhaustObject);
        if (!carControl.NGear) AkSoundEngine.SetRTPCValue("RTPC_Load", carControl._gasInput, engineObject);
        if (carControl.NGear)
        {
            AkSoundEngine.SetRTPCValue("RTPC_Load", 0f, exhaustObject);
            AkSoundEngine.SetRTPCValue("RTPC_Load", 0f, engineObject);
        }
        AkSoundEngine.SetRTPCValue("RTPC_NOSIntencity", carControl._boostInput, exhaustObject);
        AkSoundEngine.SetRTPCValue("RTPC_NOSIntencity", carControl._boostInput, engineObject);
        
        

        if (carControl._boostInput > 0f && !NOSplaying)
        {
            NOSplaying = true;
            NOS.Post(exhaustObject);

        }
        if (carControl._boostInput <= 0f)
        {
            NOSplaying = false;
            NOS.Stop(exhaustObject);
        }
        if (changeGear && !changed)
        {
            if (previousGear < carControl.currentGear)
            {
                changed = true;
                gearShiftUp.Post(gameObject);
            }
            if (previousGear > carControl.currentGear)
            {
                changed = true;
                gearShiftDown.Post(gameObject);
            }
        }
        previousGear = carControl.currentGear;
        if (carControl.gasInput > 0f && carControl.gasInput  < 1f && carControl.engineRPM < 2000f && !accelCor && carControl.speed < 25f)
        {
            StartCoroutine(Accel());
        }
        if (accelCor && carControl.engineRPM > 3000f)
        {
            accelExhaust.Stop(exhaustObject);
            accelEngine.Stop(engineObject);
        }
    }

    private void OnGUI()
    {
        /*
        GUI.Label(new Rect(50, 25, 200, 30), "RPM: " + carControl.engineRPM.ToString());
        GUI.Label(new Rect(50, 45, 200, 30), "Drifting angle: " + carControl.driftAngle.ToString());
        GUI.Label(new Rect(50, 65, 200, 30), "Drifting now: " + carControl.driftingNow.ToString());
        GUI.Label(new Rect(50, 85, 200, 30), "Speed: " + carControl.speed.ToString());
        GUI.Label(new Rect(50, 105, 200, 30), "Direction " + carControl.direction.ToString());
        GUI.Label(new Rect(50, 125, 200, 30), "NOS amount: " + carControl.NoS.ToString());
        GUI.Label(new Rect(50, 145, 200, 30), "Gas input: " + carControl._gasInput.ToString());
        GUI.Label(new Rect(50, 165, 200, 30), "Boost input: " + carControl._boostInput.ToString());
        GUI.Label(new Rect(50, 185, 200, 30), "Brake input: " + carControl._brakeInput.ToString());
        GUI.Label(new Rect(50, 205, 200, 30), "Steer input: " + carControl._steerInput.ToString());
        GUI.Label(new Rect(50, 225, 200, 30), "Turbo boost: " + carControl.turboBoost.ToString());
        GUI.Label(new Rect(50, 245, 200, 30), "Brightness: " + lfBrightness.brightness.ToString());
        GUI.Label(new Rect(50, 265, 200, 30), "Current Gear: " + carControl.currentGear.ToString());
        GUI.Label(new Rect(50, 285, 200, 30), "Handbrake input: " + carControl.handbrakeInput.ToString());
        */
    }

    private IEnumerator Accel()
    {
        accelCor = true;
        accelExhaust.Post(exhaustObject);
        accelEngine.Post(engineObject);
        //Debug.Log("AccelExhaust");
        //Debug.Log("AccelEngine");
        yield return new WaitForSeconds(0.05f);
        accelCor = false;
    }


}

