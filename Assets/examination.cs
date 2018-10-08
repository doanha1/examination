using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examination : MonoBehaviour
{
    public SpriteRenderer rend;
    public float movespeed = 5f;
    public float rotationspeed = 360f;
    public int Vector3;
    public float timerText;
    public float number = 1;
    public int Vector2;

    void Start()
    {
        //Skeppet spawnar på en random position innanför skärmen när spelet startar.
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
        transform.position = position;

    }

    void Update()
    {
        //SKeppet åka framåt
        transform.Translate(movespeed * Time.deltaTime, 0, 0, Space.Self);

        //När man trycker på D så ska skeppet svänga höger och bli blått
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
            rend.color = Color.blue;
        }

        //När man trycker på A så ska skeppet svänga vänster och bli grönt
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationspeed / 2 * Time.deltaTime);
            rend.color = Color.green;
        }

        //När man trycker på S så ska skeppet flyga hälften så snabbt och när man släpper S så ska farten bli samma igen
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-movespeed /2 * Time.deltaTime, 0, 0, Space.Self);
        }
        
        //Timer printa ut värdet varje sekund
        timerText = timerText + Time.deltaTime;

        if(timerText >= number)
        {
            print(timerText);
            number = number + 1;
        }

        //När man trycker Spacebar så ska skeppet få en random färg
        if (Input.GetKey(KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        
    }

}
