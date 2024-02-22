namespace hada_p1
{
    class HadaP1{
        //Metodo que convierte de segundos a minutos pasandole los segundos
        public static double Seconds2Minutes(double s)
        {
            //Setencia if que si el dato pasado es 0 devuelve 0
            if (s == 0)
            {
                return 0;
            }
            //Si no es 0 hace la conversion y lo devuelve
            else
            {

                //Devuelve la conversion
                return s / 60;
            }
        }
        //Metodo que convierte de minutos a segundos pasandole los segundos
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }


    }
}
