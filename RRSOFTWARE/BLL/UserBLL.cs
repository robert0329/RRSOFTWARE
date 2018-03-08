using RRSOFTWARE.DAL;
using RRSOFTWARE.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRSOFTWARE.BLL
{
    public class UserBLL
    {
        public static bool Create(User user)
        {
            bool result = false;
            using (var conn = new RRSOFT())
            {
                try
                {
                    var search = Search(user.UserId);
                    if (search == null)
                        conn.User.Add(user);
                    else
                        conn.Entry(user).State = EntityState.Modified;
                    conn.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return result;
            }
        }
        public static User Search(int UserId)
        {
            var search = new User();
            using (var conn = new RRSOFT())
            {
                try
                {
                    search = conn.User.Find(UserId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return search;
        }
        public static User Search(string Name)
        {
            var user = new User();
            using (var conn = new RRSOFT())
            {
                try
                {
                    user = conn.User.Where(c => c.Name.Equals(Name)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return user;
        }
        public static bool Delete(User exist)
        {
            bool result = false;
            using (var conn = new RRSOFT())
            {
                try
                {
                    conn.Entry(exist).State = EntityState.Deleted;
                    conn.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return result;
        }
        public static List<User> GetList()
        {
            var list = new List<User>();
            using (var conn = new RRSOFT())
            {
                try
                {
                    list = conn.User.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;
        }
        public static List<User> GetListId(int UserId)
        {
            List<User> list = new List<User>();
            using (var conn = new RRSOFT())
            {
                try
                {
                    list = conn.User.Where(p => p.UserId == UserId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;
        }
        public static int Identity()
        {
            int UltimoId = 0;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chico\Documents\RRSOFTWARE\RRSOFTWARE\Database\RRSOFTWARE.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand comando = new SqlCommand("Select IDENT_CURRENT('User')", conn);
            conn.Open();
            UltimoId = Convert.ToInt32(comando.ExecuteScalar());
            conn.Close();
            return UltimoId;
        }
    }
}
