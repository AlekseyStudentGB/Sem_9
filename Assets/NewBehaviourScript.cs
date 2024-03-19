using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float timer;
    public float power;
    private Rigidbody[] arry;
    public float radius;


    // Start is called before the first frame update
    void Start()
    {
    arry = FindObjectsOfType<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){
            Boom();
        }
        
    }
    void Boom(){
        foreach (Rigidbody x in arry){
            float dist = Vector3.Distance(x.transform.position, transform.position);
            if (radius - dist >=0)
            {
                Vector3 vec = x.transform.position - transform.position;
                x.AddForce(vec.normalized * power * dist);
            }
        }
    }
}
