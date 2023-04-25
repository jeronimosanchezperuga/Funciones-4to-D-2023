using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mosca : MonoBehaviour
{
    Vector3 initialPosition;
    public int livesCount = 3;
    public TextMeshProUGUI txtLives;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        txtLives.text = livesCount.ToString();
    }

    //Destruir la mosca si colisiona con el ventilador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Damager"))
        {
            LoseALife();
        } else if (collision.gameObject.CompareTag("Coin"))
        {
            //crear la funcion ScorePoint (con sus variables y elementos UI)
            ScorePoint();
            Destroy(collision.gameObject);
        } 
    }

    void LoseALife()
    {
        transform.position = initialPosition;
        livesCount--;
        txtLives.text = livesCount.ToString();
        if (livesCount == 0)
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        Destroy(gameObject);
        //reproducir un sonido
        //ejecutar una animacion
        //etc
    }
}
