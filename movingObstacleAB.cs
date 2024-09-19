using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public Transform pointA; // O primeiro ponto
    public Transform pointB; // O segundo ponto
    public float speed = 3f; // Velocidade do movimento

    private Vector3 targetPosition; // Posi��o alvo atual

    void Start()
    {
        // Define o ponto inicial como o alvo
        targetPosition = pointB.position;
    }

    void Update()
    {
        // Move o objeto em dire��o ao ponto alvo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Troca o alvo para o outro ponto
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition == pointB.position)
            {
                targetPosition = pointA.position;
            }
            else
            {
                targetPosition = pointB.position;
            }
        }
    }
}

