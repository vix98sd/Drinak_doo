﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Magacin
    {
        public Magacin(int id_robe, string naziv, double kolicina, int jmid)
        {
            Id_robe = id_robe;
            Naziv = naziv;
            Kolicina = kolicina;
            this.jmid = jmid;
            jmm = null;
        }
        public int Id_robe { get; set; }
        public string Naziv { get; set; }
        public double Kolicina { get; set; }

        private int jmid;
        private JedinicaMere jmm;
        public void SetJM(JedinicaMere JM)
        {
            this.jmm = JM;
        }
        public JedinicaMere GetJM()
        {
            if (this.jmm == null)
            {
                SetJM(jmid);
            }
            return jmm;
        }
        public JedinicaMere Jm { get; set; }

        private void SetJM(int jmid)
        {
            JediniceMereRepository JMR = new JediniceMereRepository();
            SetJM(JMR.GetJedinicaMereByID(jmid));

            /*
            List<JedinicaMere> jediniceMere = JMR.GetJediniceMere();

            foreach(JedinicaMere jedinicaMere in jediniceMere)
            {
                if (jedinicaMere.Id_jm == jmid)
                {
                    Jm = jedinicaMere;
                    break;
                }
            }
            */
        }

    }
}
