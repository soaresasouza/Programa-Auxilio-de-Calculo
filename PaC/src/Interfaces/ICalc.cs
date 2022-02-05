using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaC.src.Interfaces
{
    // uma interface simples que inclui os metodos que eu preciso incluir
    public interface ICalc
    {
        void SolicitarDados();
        double Calcular();
        void MostrarDados();
    }
}