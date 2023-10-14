using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    public int lifes = 10;
    public Text x;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        x.text = lifes.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * Speed);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Probitie");
        lifes--;
        x.text = lifes.ToString();
    }
}
