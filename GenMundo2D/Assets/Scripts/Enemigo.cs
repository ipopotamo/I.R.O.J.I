using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    private int rand;

    private ListaSpawnItem templates;

    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("STATS").GetComponent<ListaSpawnItem>();
    }
    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            rand = Random.Range(0, templates.items.Length);
            Instantiate(templates.items[rand], this.transform.position, Quaternion.Euler(5, -1, 0));
            Destroy(gameObject);
        }
    }
}

