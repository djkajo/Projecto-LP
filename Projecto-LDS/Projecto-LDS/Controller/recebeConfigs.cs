﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_LDS.Model
{
    class recebeConfigs
    {
            public void configsTarifaSimples(string tarifaSimples)
            {
                double tarifaSimplesD = Convert.ToDouble(tarifaSimples);
            }

            public void configsBihoraria (string tarifaBiVazio, string tarifaBiFora)
            {
                double tarifaBiVazioD = Convert.ToDouble(tarifaBiVazio);
                double tarifaBiForaD = Convert.ToDouble(tarifaBiFora);
            }
            
            public void configsGN (string tarifaGN)
            {
                double tarifaGnD = Convert.ToDouble(tarifaGN);
            }
       

    }
}