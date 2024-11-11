using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: wanneer drukt iemand op wasd of pijltjes?
        //TODO: player gaat voruit met w of pijl omhoog
        //achteruit met S of pijltje omlaag
        //Draai naar lijnks bij A of pijl links
        //Draai naar rechts bij D of pijl naar rechts

        
        float inputVer = Input.GetAxis("Vertical");

        float inputHor = Input.GetAxis("Horizontal");
        if (inputHor != 0)
        {
            //wel input
            gameObject.transform.Rotate(0, inputHor, 0);
        }
        else { 
            //geen input
        }
        if (inputVer != 0)
        {
            //transform.forward
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
