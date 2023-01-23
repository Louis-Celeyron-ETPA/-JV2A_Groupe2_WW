using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// playermanager non utilisé pour le moment.
// placeholder n'apparaisent la aussi pas, et le jeu perds son sens sans les rendus finaux...
// Le principe était de voir l'entité "ennemi" faire un mouvement, le joueur devant le reproduire via les controlles dans une limite de temps.
//aucune idée de comment programmer, aléatoirement ou linéairement, les mouvements de l'ennemi.
public class Playerposing : MonoBehaviour
{

    public SpriteRenderer _spriteRenderer;
    public Color upColor, leftColor, rightColor, downColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
            ChangeColor(upColor);

        if (Input.GetKey(KeyCode.D))
            ChangeColor(rightColor);

        if (Input.GetKey(KeyCode.Q))
            ChangeColor(leftColor);

        if (Input.GetKey(KeyCode.S))
            ChangeColor(downColor);
    }

    public void ChangeColor(Color color)
    {
        _spriteRenderer.color = color;
    }
}

