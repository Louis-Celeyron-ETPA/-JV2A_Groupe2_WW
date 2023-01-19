using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Brandon
{

    public class CharacterEvent : MonoBehaviour
    {

        public List<Transform> characters;
        public GameObject target;
        public GameObject exit;
        private Transform characterTransform, targetPosition;
        public float speed;
        public bool gameOver = false;
        private bool characterStop = false;


        // Start is called before the first frame update
        void Start()
        {
            ChooseCharacter();
        }

        // Update is called once per frame
        void Update()
        {
            if (!gameOver)
            {
                if (characterTransform.position != targetPosition.position && !characterStop)
                {
                    MoveCharacter();
                }
                else if (characterTransform.position == targetPosition.position)
                {
                    characterStop = true;
                    StartCoroutine(CharacterWait());
                    StartCoroutine(ChangeCharacter());
                }


            }
        }

        void ChooseCharacter()
        {
            var characterTurn = Random.Range(0, 7);
            speed = Random.Range(0.05f, 0.1f);
            characterTransform = characters[characterTurn];
            targetPosition = target.transform;

        }

        void MoveCharacter()
        {

            characterTransform.position = Vector3.MoveTowards(characterTransform.position, targetPosition.position, speed);

        }

        IEnumerator CharacterWait()
        {
            yield return new WaitForSeconds(2);
            var previousCharacterTransform = characterTransform;
            previousCharacterTransform.position = Vector3.MoveTowards(previousCharacterTransform.position, exit.transform.position, speed);
            
        }

        IEnumerator ChangeCharacter()
        {
            yield return new WaitForSeconds(4);
            ChooseCharacter();
        }
    }
}