using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    int liczbacalkowita;
    //float liczbaprzecinkowa = 0.1f;

    public float speed = 5;
    public Rigidbody rigidbody;
    public Transform startPoint;
    public int zebranePunkty;
    void Start()
    {
        Debug.Log("Use WSAD to move");
        //tekst wyœwietlany w konsoli
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float directionHorizontal = Input.GetAxis("Horizontal");
            rigidbody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float directionVertical = Input.GetAxis("Vertical");
            rigidbody.AddForce(0, 0, directionVertical * Time.deltaTime * speed, ForceMode.Impulse);
        }

        //Debug.Log(rigidbody.velocity);

        if (transform.position.y < -1)
        {
            transform.position = startPoint.position;
            rigidbody.velocity = Vector3.zero;

            Vector3 test = new Vector3(0, 1, 0);
        }
        /*
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(-1 * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(1 * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
            //transform.position = new Vector3(1, 1, 1);
            //przesuwa w dok³adn¹ pozycjê
            //transform.position = new Vector3(transform.position.x + liczbaprzecinkowa, transform.position.y, transform.position.z);
            //transform.Translate(1 * Time.deltaTime * speed, 0, 0);
        }

        */

    }
}
