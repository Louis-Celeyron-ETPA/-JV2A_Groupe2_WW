using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class ListeLettre : MonoBehaviour
    {
        public List<int> couleurLettre = new List<int>();

        public List<MesLettres> listeDesLettres = new List<MesLettres>();

        public List<Color> couleursDispo = new List<Color>();
        public int nombreLettre;
        public MesLettres maLettre;
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < nombreLettre; i++)
            {
                int colorPick = Random.Range(0, 4);

                couleurLettre.Add(colorPick);

                MesLettres lettreCree = Instantiate(maLettre, new Vector3(-10 + (i * 2), -2, -13), Quaternion.identity);

                lettreCree.mr.material.color = couleursDispo[colorPick];
                listeDesLettres.Add(lettreCree);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
