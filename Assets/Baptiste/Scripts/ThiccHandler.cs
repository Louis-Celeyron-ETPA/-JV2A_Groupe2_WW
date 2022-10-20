using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Baptiste;

namespace Baptiste {
    public class ThiccHandler : MonoBehaviour
    {
        private Vector3 omniThick;
        private Vector3 omniThinn;
        private bool twerking;
        private int score;

        public TMP_Text textScore;        
        public GameObject mailManBack;

        // Start is called before the first frame update
        void Start()
        {
            score = 0;
            omniThick = new Vector3(0f, 0f, -1f);
            omniThinn = new Vector3(0f, -12f, -1f);
        }

        // Update is called once per frame
        void Update()
        {
            if (twerking && mailManBack.transform.position.x == 11)
            {
                score += 10;
            }
            else if (twerking && mailManBack.transform.position.x != 11)
            {
                score -= 10;
            }
            textScore.text = "" + score;
        }

        public void Twerking()
        {
            transform.position = omniThick;
            twerking = true;
        }

        public void NoTwerking()
        {
            transform.position = omniThinn;
            twerking = false;
        }
    }
}
