using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exhaustPop : MonoBehaviour
{
    private Light lit;
    private LensFlare lf;
    public AK.Wwise.Event pop;
    // Start is called before the first frame update
    void Start()
    {
        lit = GetComponent<Light>();
        lf = GetComponent<LensFlare>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((lf.color.r == 255 && lf.color.g == 153 && lf.color.b == 0) /*&& lf.brightness > 0.5f*/)
        {
            //StartCoroutine(PopSound());
            pop.Post(gameObject);
            
        }
    }

    /*private IEnumerator PopSound()
    {
        pop.Post(gameObject);
        yield return new WaitForSeconds(0.5f);
    }*/
}
