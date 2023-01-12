using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Baptiste;

namespace Baptiste {
    public class ThiccHandler : MonoBehaviour
    {
        private Vector3 omniThickPosition;
        private Vector3 omniThinnPosition;
        private bool twerking;
        public int score;

        public GameObject omniThinn;
        public TMP_Text textScore;        
        public GameObject mailManBack;

        // Start is called before the first frame update
        void Start()
        {
            score = 0;
            omniThickPosition = new Vector3(0f, 0f, 0f);
            omniThinnPosition = new Vector3(0f, -12f, 0f);
        }

        // Update is called once per frame
        void Update()
        {
            if (twerking && mailManBack.transform.position.x == 6)
            {
                score += 10;
            }
            else if (twerking && mailManBack.transform.position.x != 6)
            {
                score -= 10;
            }
            textScore.text = "" + score;
        }

        public void Twerking()
        {
            transform.position = omniThickPosition;
            omniThinn.transform.position = omniThinnPosition;
            twerking = true;
        }

        public void NoTwerking()
        {
            transform.position = omniThinnPosition;
            omniThinn.transform.position = omniThickPosition;
            twerking = false;
        }
    }
}
