using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class CreateTempo : MonoBehaviour
    {
        public int tempoTotal;
        public int errorCheck;

        public float delaisTempo;
        public int timerTempo;
        public int noteNumber = 1;
        public CreateTempo self;

        public int rythmNumber = 0;

        public int variableTimer;

        public TempoRythm maNote;

        public List<Sprite> MCpopePV;
        public SpriteRenderer MCpope;

        // Start is called before the first frame update
        void Start()
        {
            variableTimer = Random.Range(1, 3);
        }

        // Update is called once per frame
        void Update()
        {
            if (errorCheck == 0)
            {
                MCpope.sprite = MCpopePV[0];
            }
            else if (errorCheck == 1)
            {
                MCpope.sprite = MCpopePV[1];
            }
            else
            {
                MCpope.sprite = MCpopePV[2];
            }

                timerTempo++;

            if ((timerTempo > variableTimer * delaisTempo) && (tempoTotal != noteNumber-1))
            {
                variableTimer = Random.Range(1, 3);
                timerTempo = 0;

                TempoRythm noteTempo = Instantiate(maNote, new Vector3(10, 4.6f, 14), Quaternion.identity);
                noteTempo.IDchecker = self;
                noteTempo.noteID = noteNumber;
                noteTempo.monPope = MCpope;
                noteNumber++;
            }

            if (errorCheck >= 3)
            {
                Debug.Log("défaite");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }

        public void rythmAugmentation()
        {
            if (rythmNumber < noteNumber-1)
            {
                rythmNumber++;
            }
            if ((rythmNumber > 19) && (errorCheck < 3))
            {
                Debug.Log("victoire !");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
    }
}
