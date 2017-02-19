using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Sorted.Src.Interface;

namespace Sorted.Src
{
    public class DataBase : IDataBase
    {
        protected Dictionary<string, string> szConnectionData = new Dictionary<string, string>();
        private SqlConnection cnn { get; set; }

		public void DataBase()
		{
		    this.LoadSettings(new XmlReader("Config.xml"));
		}
		
        public void LoadSettings(XmlReader xml)
        {
           while (xml.Read())
            {
                if (xml.IsStartElement())
                {
                    switch (xml.Name)
                    {
                        case "Login":
                            this.szConnectionData.Add("Login", xml["Login"]);
                            break;
                        case "Password":
                            this.szConnectionData.Add("Password", xml["Password"]);
                            break;
                        case "Port":
                            this.szConnectionData.Add("Port", xml["Port"]);
                            break;
                        default:
                            throw new Exception("Settings not found!");                            
                    }
                }
            }
        }

        public void SaveItem(DataGridView ItemList)
        {
            Dictionary<string, string> Data = new Dictionary<string,string>();
            Data.Add("table", "GoodsInfoList");
            Data.Add("rows", "GoodsId, ItemName...");
            string[] values = { };

            for (int i = 0; i < ItemList.Rows.Count; i++)
            {
                values[i] = ItemList.Rows[i].Cells[i].Value.ToString();
            }

            this.Save(Data, values);
        }

        public void Connect()
        {
            this.cnn = new SqlConnection();
        }


        public void Save(IDictionary data, string[] values)
        {
            SqlCommand query = new SqlCommand();
            query.Connection = this.cnn;
            query.CommandText = @"INSERT INTO " + data["table"] + data["rows"] + values;
            query.ExecuteNonQuery();
        }

        public void Update(string table, IList list)
        {
            SqlCommand query = new SqlCommand();
            query.Connection = this.cnn;
            query.CommandText = @"UPDATE " + list[0] + " SET " + list[1] + "WHERE " + list[2] + " = " + list[3];
            query.ExecuteNonQuery();
            throw new NotImplementedException();
        }
    }
}
