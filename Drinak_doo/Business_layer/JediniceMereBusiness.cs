using Data_layer;
using Data_layer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class JediniceMereBusiness
    {

        public List<JedinicaMere> GetJediniceMere()
        {
            JediniceMereRepository JMR = new JediniceMereRepository();
            return JMR.GetJediniceMere();
        }

    }
}
