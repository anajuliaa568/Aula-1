using Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Controller
{
    public class CarrosController
    {
        public static void ReadExcel()
        {

            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hbsis\Desktop\excel.xls;" +
      @"Extended Properties='Excel 8.0;HDR=Yes;'");
            string comandoSql = "Select * from [Worksheet$]";
            OleDbConnection connection = null;
            OleDbCommand comando = new OleDbCommand(comandoSql, connection);
            try

            {

                connect.Open();
                OleDbDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ProgramContext.listaCarro.Add(new Carros()
                    {
                        Id = Convert.ToInt32(rd["id"]),
                        Nome = rd["Nome"].ToString(),
                        Valor = Convert.ToDouble(rd["Valor"]),
                        Quantidade = Convert.ToInt32(rd["Quantidade"]),
                        Data = Convert.ToDateTime(rd["Data"])
                    });
                 }
            }
            catch (Exception)
            {

                throw;
            }
         }
    }
}






