using System;

namespace mercedes
{
    class Mercedes
    {
        private string model;
        private int pretEuro;
        private int greutateKg;

        public void setDate(string _model , int _pret , int _greutate)
        {
            model = _model;
            pretEuro = _pret;
            greutateKg = _greutate;
            Console.WriteLine("Model " + _model + "Pretul " + _pret + " Greutate " + _greutate);
        }
    }
}