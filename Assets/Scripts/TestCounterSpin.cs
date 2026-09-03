using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCounterSpin : MonoBehaviour
{
    public float spinSpeed = 100f;

    private void OnCollisionStay(Collision collision)
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        if (collision.gameObject.CompareTag("SmallCog"))
        {
            collision.gameObject.transform.Rotate(Vector3.up, -spinSpeed * Time.deltaTime);
        }

        if (collision.gameObject.CompareTag("Shaft"))
        {
            collision.gameObject.transform.Rotate(Vector3.right, -spinSpeed * Time.deltaTime);
        }

    }

}
