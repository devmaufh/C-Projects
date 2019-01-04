using System;
namespace Conductores
{
    class Conduce
    {
        int edad = 0;
        
        public Conduce(int e)
        {
            edad = e;
        }
        public Boolean veredicto(Boolean p)
        {
            Boolean permiso = p;
            if(edad >= 18)return true; 
            else if (edad == 15 && p) return true;
            else return false;
        }
    }

}