using Model.Entity;
using Model.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class ChipDAO
    {

        //Metodo para Mostrar
        public List<Chip> Listado() 
        {
            using (var data=new ApplicationDB())
            {
                return data.Chip.OrderBy(x => x.ID).ToList();
            }
        
        
        }


        //Metodo para Filtrar

        public List<Chip> Buscar(Chip chip) 
        {
        string sql= "select * from chip where Compañia like '%"+chip.Compañia + "%'";
            using (var data=new ApplicationDB())
            {
                return data.Database.SqlQuery<Chip>(sql).ToList();
            }

        }

        //Agregar 
        public void Agregar(Chip chips) 
        {
            using (var data=new ApplicationDB())
            {
                data.Chip.Add(chips);
                data.SaveChanges();

            }
        
        }

        //Eliminar
        public void Eliminar(int id)
        {
            using (var data=new ApplicationDB())
            {
                var lista = data.Chip.Find(id);
                data.Chip.Remove(lista);
                data.SaveChanges();
            }

        }

        //Obtener ID
        public Chip ObtenerId(int id)
        {
            using (var data=new ApplicationDB())
            {
              return   data.Chip.Where(x => x.ID == id).FirstOrDefault();

            }
        }

        //Actualizar
        public void Actualizar(Chip chip)
        {
            using (var data=new ApplicationDB())
            {
                var lista = data.Chip.Find(chip.ID);
                lista.Compañia = chip.Compañia;
                lista.Numero = chip.Numero;
                lista.Pink = chip.Pink;
                lista.Punk = chip.Punk;
                data.SaveChanges();
            }

        }


        //MOstrar Chip por Cliente
        public List<ChipCliente>MostrarChipCliente(ChipCliente chip)
        {
            string sql = "select c.Cedula,c.Nombre,c.Apellido,c.Apellido,c.Edad,c.Direccion,c.ChipId,p.ID,p.Compañia,p.Numero,p.Pink,p.Punk from Cliente c inner join Chip p on c.ChipId=p.ID where c.ChipId='" + chip.ChipId + "'";

            using (var data=new ApplicationDB())
            {
                return data.Database.SqlQuery<ChipCliente>(sql).ToList();
            }
        }
    }
}
