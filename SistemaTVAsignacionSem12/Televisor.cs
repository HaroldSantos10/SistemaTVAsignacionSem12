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

        //metodo para insertar o editar un registro
        public Boolean newEditBook(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO televisor(marca, modelo, color, size, year)" +
                    "VALUES ('" + _idTv + "', '" + _marca + "', '" + _modelo + "', '" + _color + "', '" + _size + "', '" + _year + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE book SET "
                    + "marca='" + _marca + "' ,"
                    + "modelo='" + _modelo + "',"
                    + "color='" + _color + "',"
                    + "size='" + _size + "',"
                    + "year='" + _year + "'"
                    + "WHERE "
                    + "tvId='" + _idTv + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        //metodo para eliminar
        public Boolean deleteBook()
        {
            string query = "DELETE FROM book WHERE tvId='" + _idTv + "'";
            crud.executeQuery(query);
            return true;
        }


    }
}
