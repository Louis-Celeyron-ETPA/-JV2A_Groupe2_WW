using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    
public class generateWindow : MonoBehaviour {

        public GameObject maFenetre;
        public List<int> typeWindow = new List<int>();
        public int nombrewnWindow;


        // Start is called before the first frame update
        void Start()
        {
        for (int i = 0; i < nombrewnWindow; i++)
        {
            int fenetreRandom = Random.Range(0, 1);
                typeWindow.Add(fenetreRandom);

            Instantiate(maFenetre, new Vector3(2, 2 - i, -13), Quaternion.identity);
        }
    }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
