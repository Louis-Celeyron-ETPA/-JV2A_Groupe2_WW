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
        private Transform characterTransform, targetPosition, previousCharacterTransform;
        public float speed;
        public bool gameOver = false;
        private bool characterChanged = false;


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
                if (characterTransform.position != targetPosition.position)
                {
                    MoveCharacter();
                }
                else if (characterTransform.position == targetPosition.position)
                {
                    characterChanged = false;
                    CharacterOut();
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

        void CharacterOut()
        {
            if (characterTransform.position == targetPosition.position)
            {
                StartCoroutine(ExitCharacter());
            }
        }

        IEnumerator ExitCharacter()
        {
            yield return new WaitForSeconds(Random.Range(1,3));
            if(!characterChanged)
            {
                previousCharacterTransform = characterTransform;
                ChooseCharacter();
                characterChanged = true;
            }

            if (previousCharacterTransform != characterTransform)
            {
                previousCharacterTransform.position = Vector3.MoveTowards(previousCharacterTransform.position, exit.transform.position, speed);
                
            }
            
        }
    }
}