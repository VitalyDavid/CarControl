using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfaceRaycast : MonoBehaviour
{
    //public GameObject LFtire, RFtire, LBtire, RBtire;
    //public GameObject[] tires;
    public GameObject tires;
    public LayerMask lm;
    public AK.Wwise.Event tire;
    public RCC_CarControllerV3 carControl;
    public string surfaceType;
    private bool cor;
    public bool isAirborne;
    // Start is called before the first frame update
    void Start()
    {
        tire.Post(tires);
    }

    private void Update()
    {


        if (Physics.Raycast(tires.transform.position, Vector3.down, out RaycastHit hit, 1f, lm))
        {
            isAirborne = false;
            if (hit.collider.tag != null)
            {
                surfaceType = hit.collider.tag;
            }
            switch (hit.collider.tag)
            {
                case "Gravel":
                    AkSoundEngine.SetSwitch("Surface", "Gravel", tires);
                    //Debug.Log("Surface:" + hit.collider.tag);
                    break;
                case "Asphalt":
                    AkSoundEngine.SetSwitch("Surface", "Asphalt", tires);
                    //Debug.Log("Surface:" + hit.collider.tag);
                    break;
                case "Grass":
                    AkSoundEngine.SetSwitch("Surface", "Grass", tires);
                    //Debug.Log("Surface:" + hit.collider.tag);
                    break;
            }
            /*if (!cor)
            {
                StartCoroutine(SurfaceDelay());
            }*/
        }
        else isAirborne = true;

        AkSoundEngine.SetRTPCValue("RTPC_Speed", carControl.speed, tires);
    }

    private IEnumerator SurfaceDelay()
    {
        cor = true;
        yield return new WaitForSeconds(1f);
        cor = false;
    }
}
