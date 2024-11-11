using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientodepersonaje : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speedx;
    public float speedy;
    private Rigidbody2D _compRigidbody2D;
    // Start is called before the first frame update
    private void Awake()
    {

        _compRigidbody2D = GetComponent<Rigidbody2D>();
    
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _compRigidbody2D.velocity = new Vector2(speedx * horizontal, speedy * vertical);
    }
}
