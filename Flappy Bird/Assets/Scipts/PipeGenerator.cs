using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    private float timer = 0;
    private float maxtimer = 1.8f;
    public GameObject pipe;
    public float pipeheight;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0,Random.Range(-pipeheight,pipeheight),0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxtimer)
        {
            
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0,Random.Range(-pipeheight,pipeheight),0);
            Destroy(newpipe, 10f);
            timer = 0;
        }
        timer += Time.deltaTime;
        
    }
}
