using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Nacladnaya
{
    public class DAL
    {
        public static OrderEntity GetOrderById(int OrderId)
        {
            OrderEntity order = new OrderEntity();

            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.conStr);
            
            string cmdText = "SELECT Заказы.NППЗаказа as OrderId," +
                             "Заказы.NЗаказаЗавода as OrderNumber," +
                             "КодыНаименованийТО.НаименованиеТО + ' ' + Заказы.ОбозначениеТО + ' ' + Детали.НаименованиеДетали AS OrderDescription," +
                             "Заказы.NЗаказа + ' ' + Заказы.ОбозначениеТО + ' ' + КодыНаименованийТО.НаименованиеТО  AS OrderCaption," +
                             "Заказы.Кол_во as Qty," +
                             "Заказы.p_unit as UnitName, " +
                             "IIf([Стойкость] Is Null,'',CStr([Стойкость])) as Stoikost " +
                             "FROM КодыНаименованийТО INNER JOIN " +
                             "(Детали INNER JOIN Заказы ON Детали.NДетали = Заказы.NДетали) ON КодыНаименованийТО.КодТО = Заказы.КодТО " +
                             "WHERE Заказы.NППЗаказа=?";
            
            OleDbCommand cmd = new OleDbCommand(cmdText, con);
            OleDbParameter par = new OleDbParameter();
            par.Value = OrderId;
            cmd.Parameters.Add(par);
            try
            {
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    order.OrderId = (int)reader["OrderId"];
                    order.OrderNumber = (string)reader["OrderNumber"];

                    if (order.OrderNumber.StartsWith("23-"))
                        order.OrderDescription = (string)reader["OrderCaption"];    
                    else
                        order.OrderDescription = (string)reader["OrderDescription"];

                    order.Qty = (int)reader["Qty"];
                    order.UnitName = (string)reader["UnitName"];
                    order.Stoikost = (string)reader["Stoikost"];
                }
                reader.Close();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message);
                return order;
            }

            return order;
        }
    }
}
