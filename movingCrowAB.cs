using UnityEngine;

public class MovingCrow : MonoBehaviour
{
    public Transform pointA; // O primeiro ponto
    public Transform pointB; // O segundo ponto
    public float speed = 3f; // Velocidade do movimento

    private Vector3 targetPosition; // Posição alvo atual

    void Start()
    {
        // Define o ponto inicial como o alvo
        targetPosition = pointB.position;
    }

    void Update()
    {
        // Move o objeto em direção ao ponto alvo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Troca o alvo para o outro ponto
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition == pointB.position)
            {
                transform.Rotate(0f, 180f, 0f); // Rotaciona o objeto 180 graus no eixo Y a partir da sua rotação atual
                targetPosition = pointA.position;
            }
            else
            {
                targetPosition = pointB.position;
                transform.Rotate(0f, 180f, 0f);
            }
        }
    }
}

