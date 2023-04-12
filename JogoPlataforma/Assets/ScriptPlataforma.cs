using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlataforma : MonoBehaviour
{
    private Vector2 posInicial;
    private float cont;
    public float deslocamento;
    public float largura;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        deslocamento = 1;
        largura = 0;
        altura = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(cont) * largura;
        float y = Mathf.Cos(cont) * altura;

        transform.position = new Vector2(posInicial.x + x, posInicial.y + y);

        cont += deslocamento * Time.deltaTime;

        if(cont >= 2 * Mathf.PI)
        {
            //cont = 0; para o contador voltar para o valor 0 hora que passar do valor 2pi.
            cont = cont - 2 * Mathf.PI;//faz o ajuste fine, pois o cont vai passar o valor de 2Pi, assim ele vai jogar a diferença desse valor e nao vai realocar a plataforma.

        }
    }
}
