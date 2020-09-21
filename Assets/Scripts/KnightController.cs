using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
{

    public float speed = 200.0f;
    private float _h, _v;
    private Rigidbody2D _rb2dBody;


    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    //Utilizando o FixedUpdate para movimentação do Knight, para que não haja
    //oscilação devido ao FPS (isso faz com que a movimentação seja mais flúida
    void FixedUpdate()
    {
        //Variáveis que recebem o comando de movimentação feita pelo jogador, nos eixos horizontal e vertical
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");

        //Realiza o cálculo da velocidade que o Knight deverá se mover (direção * velocidade * ▲time) 
        //   ▲time serve para que seja considerado metros por segundo e nao frames por segundo.
        _rb2dBody.velocity = new Vector2(_h * speed * Time.deltaTime, _v * speed * Time.deltaTime);
    }
}
