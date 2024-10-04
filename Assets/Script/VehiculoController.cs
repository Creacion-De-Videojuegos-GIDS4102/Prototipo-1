using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculoController : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Movimiento")]

    [SerializeField] private float velocidadMovimiento;

    [SerializeField] private float acelerar;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        acelerar = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y , acelerar * velocidadMovimiento);
    }
}
