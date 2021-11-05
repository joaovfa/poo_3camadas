using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetonetflix11900490.Code.DTO
{
    class NetflixDTO
    {
        //Properiedades privadas
        private int _id;
        private string _usuario;
        private string _assistindo_no_momento;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Titulo_assitido_no_momento { get => _assistindo_no_momento; set => _assistindo_no_momento = value; }
    }
}
