using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaTVAsignacionSem12
{
    class Televisor
    {
        //propiedades
        public int _idTv { get; set; }
        public string _marca { get; set; }
        public string _modelo { get; set; }
        public string _color { get; set; }
        public int _size { get; set; }
        public string _year { get; set; }

        //instancia a la clase Crud
        private Crud crud = new Crud();
        
        //metodo par retornar los registros dela tabla Televisor
        public MySqlDataReader getAllTvs()
        {
            string query = "SELECT tvId,marca,modelo,color,size,year FROM televisor";

            //llamado al metodo Select de la clase Crud
            return crud.select(query);
        }

    }
}
