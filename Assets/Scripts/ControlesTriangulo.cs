using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTriangulo : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 4;

    public KeyCode teclaAvanzar;
    public KeyCode teclaRetroceder;
    public KeyCode teclaIzquierda;
    public KeyCode teclaDerecha;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        //logren que el triángulo deje de subir 
        //cuando llegue a una altura determinada

        if (Input.GetKey(teclaAvanzar))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(teclaRetroceder))
        {
            transform.Translate(0, -speed, 0);
        }

        //rotar a izq y der con las teclas A y D
        if (Input.GetKey(teclaIzquierda))
        {
            transform.Rotate(0,0,rotationSpeed);
        }
        if (Input.GetKey(teclaDerecha))
        {
            transform.Rotate(0, 0,-rotationSpeed);
        }

    }
}
