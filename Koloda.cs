using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hentgame
{
    internal class Koloda
    {
        private int _nomer;
        private string _karti;
        private int _znach;

        static int count;

        public Koloda(string karti, int nomer, int znach)
        {
            _znach = znach;
            _nomer = nomer;
            _karti = karti;
        }
        public int Znach
        {
            get => _znach;
            set => _znach = value;
        }
        public int Nomer
        {
            get => _nomer;
            set => _nomer = value;
        }
        public string Karti
        {
            get => _karti;
            set => _karti = value;
        }
    }
}
