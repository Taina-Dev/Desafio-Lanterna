using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanterna
{
    public class Lanterna : Bateria
    {
        public bool BotaoLigaDesliga { get; set; } = false;
        public bool BotaoTrocarBateira { get; set; } = false;

        public void EstadoLanterna()
        {
            Console.WriteLine($"{BotaoLigaDesliga},- {BateriaLanterna}%");
        }

        public void LigarLanterna()
        {
            BotaoLigaDesliga = true;

            for (; BateriaLanterna > 0; BateriaLanterna--)
            {
                if (BateriaLanterna == 1)
                {
                    BotaoLigaDesliga = false;
                }
            }
        }


        public void RenovarCarga()
        {
            BotaoTrocarBateira = true;
            BateriaLanterna = 100;
        }

      
    }

}

