using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaftRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //When objects begin touching

        Debug.Log(collision.gameObject.name + "started touching us");


    }

    private void OnCollisionStay(Collision collision)
    {
        //if another object is still touching

        Debug.Log(collision.gameObject.name + "is still touching us");
        transform.Rotate(-50f * Time.deltaTime, 0f, 0f, Space.Self);

    }


    private void OnCollisionExit(Collision collision)
    {
        //When object stop touching

        Debug.Log(collision.gameObject.name + "has stopped touching us");

    }



}
