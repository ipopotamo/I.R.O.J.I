using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPisoPort : MonoBehaviour
{
    private GameObject Piso;
    private Animator PlayerAnimator;
    private void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan"))
        {
            PlayerAnimator.SetTrigger("ActivarPiso");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan"))
        {
            PlayerAnimator.SetTrigger("ActivarPiso");
        }
    }
}
