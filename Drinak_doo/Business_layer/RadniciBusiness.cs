﻿using Data_layer.models;
using Data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class RadniciBusiness
    {
        public List<Radnik> GetRadnici()
        {
            RadniciRepository RR = new RadniciRepository();
            List<Radnik> radnici = RR.GetRadnici();
            for(int i = 0; i < radnici.Count; i++)
            {
                radnici[i].DoFunction();
                radnici[i].DoProcedure();
            }

            return radnici;
        }
        
        public string UpdateRadnik(Radnik radnik)
        {
            RadniciRepository RR = new RadniciRepository();
            return RR.UpdateRadnik(radnik);
        }
    }
}
