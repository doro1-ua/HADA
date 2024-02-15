namespace hada_p1
{
    class HadaP1{
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
            {
                return 0;
            }
            else
            {


                return s / 60;
            }
        }
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }


    }
}
