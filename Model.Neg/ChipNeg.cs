using Model.Data;
using Model.Entity;
using Model.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Neg
{
    public class ChipNeg
    {
        //Instancia de la clase ChipDAO
        private static ChipDAO dAO=new ChipDAO();

        //Mostrar CHIP
        public static List<Chip> Mostrar()
        {
            return dAO.Listado();
        
        }
        //Agregar CHIP
        public static void Agregar(Chip chip)
        {

            dAO.Agregar(chip);
        }
        //Eliminar
        public static void Eliminar(int id)
        {
            dAO.Eliminar(id);
        }

        //Obtener
        public static Chip Obtener(int id)
        {

            return dAO.ObtenerId(id);
        }

        //Actualizar
        public static void Modificar(Chip chip)
        {
            dAO.Actualizar(chip);
        }

        //Buscar
        public static List<Chip> Buscar(Chip chip)
        {
            return dAO.Buscar(chip);

        }
        //Mostrar chip por Cliente
        public static List<ChipCliente> MostrarChipCliente(ChipCliente chip)
        {
            return dAO.MostrarChipCliente(chip);
        }



    }
}
