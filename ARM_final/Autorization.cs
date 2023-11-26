using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARM_final
{
    internal class Autorization
    {
        static public string role, login_a, password_a;
        
        //генерация хэша пароля
        public static string GenerateHash(string password)
        {
            var enc = Encoding.GetEncoding(0);
            byte[] buffer = enc.GetBytes(password);
            var sha1 = SHA1.Create();
            var hash = BitConverter.ToString(sha1.ComputeHash(buffer));
            return hash;
        }

        static public void AutorizationMethod(string login, string password)
        {
            try
            {
                role = password_a = login_a = null;
                password = GenerateHash(password);
                SqlCommands commands = new SqlCommands();
                commands.Connection();
                NpgsqlDataReader result;
                var command = "SELECT role, login, password from role join accounts on role.id = id_role WHERE login = @login and password = @password";
                using (var cmd = new NpgsqlCommand(command, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    result = cmd.ExecuteReader();
                }
                if (result.Read())
                {
                    role = result["role"].ToString();
                    login_a = result["login"].ToString();
                    password_a = result["Password"].ToString();
                }
            }
            catch 
            {
                role = null;
                MessageBox.Show("Ошибка при авторизации!");
            }
        }
    }
}
