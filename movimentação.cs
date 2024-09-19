using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.InputSystem;

public class movimento : MonoBehaviour
{
    public float speed = 5.0f;
    public float gravity = -9.81f;
    public float jumpHeight = 1.5f;
    public float jumpSpeedMultiplier = 2.0f;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;
    private Animator animator;
    private Vector3 inputs;

    public AudioSource passosAudioSource;
    public AudioClip[] passosAudioClip;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Captura o valor do eixo horizontal
        float moveZ = Input.GetAxis("Horizontal");

        // Movimento baseado no eixo Z (horizontal)
        Vector3 move = transform.forward * moveZ;

        // Move o personagem
        controller.Move(move * speed * Time.deltaTime);

        // Aplicando a gravidade
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        // Verifica se o jogador quer pular
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Aplica gravidade ou movimento vertical
        if (velocity.y > 0)
        {
            controller.Move(Vector3.up * velocity.y * jumpSpeedMultiplier * Time.deltaTime);
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }

        // Atualiza inputs de movimento no eixo X
        inputs.Set(Input.GetAxis("Horizontal"), 0, 0);

        // Animação de andar
        if (inputs != Vector3.zero)
        {
            if (moveZ < 0)
            {
                // Se o valor de moveZ for negativo, está andando para trás
                animator.SetBool("AndandoParaTras", true);
                animator.SetBool("Andando", false); // Desliga a animação de andar para frente
            }
            else
            {
                // Se for positivo, está andando para frente
                animator.SetBool("AndandoParaTras", false);
                animator.SetBool("Andando", true);
            }
        }
        else
        {
            // Sem movimento
            animator.SetBool("Andando", false);
            animator.SetBool("AndandoParaTras", false);
        }

        // Animação de pulo
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Pulando", true);
        }
        else
        {
            animator.SetBool("Pulando", false);
        }

        // Animação de andar e pular ao mesmo tempo, tanto para frente quanto para trás
        if (inputs != Vector3.zero && Input.GetButton("Jump"))
        {
            animator.SetBool("AndandoPulando", true);
        }
        else
        {
            animator.SetBool("AndandoPulando", false);
        }
    }
    private void Passos() => passosAudioSource.PlayOneShot(passosAudioClip[Random.Range(0, passosAudioClip.Length)]);
}
