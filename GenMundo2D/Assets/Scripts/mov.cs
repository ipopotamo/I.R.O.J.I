using UnityEngine;

public class mov : MonoBehaviour
{
  private float caminar = 10f;
  private Rigidbody2D jugador;
  private Vector2 pipo;  

    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moviX = Input.GetAxisRaw("Horizontal");
        float moviY = Input.GetAxisRaw("Vertical");
        pipo       = new Vector2(moviX,moviY).normalized;
    }

    private void FixUpdate()
    {
        jugador.MovePosition(jugador.position + pipo * caminar * Time.fixedDeltaTime );
    }

}
