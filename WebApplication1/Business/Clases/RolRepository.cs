
using System.Data.SqlClient;
using WebApplication1.Business.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Business.Clases
{
    public class RolRepository : IRolRepository
    {
        private readonly string connec;

        public RolRepository(IConfiguration configuration)
        {
            connec = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Rol>> GetList()
        {
            List<Rol> list = new List<Rol>();
            Rol l;

            using (SqlConnection conn = new SqlConnection(connec))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rol", conn);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        l = new Rol
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            NombreRol = Convert.ToString(reader["NombreRol"])
                        };
                        list.Add(l);
                    }
                }
            }

            return list;
        }

        public async Task<Rol> AgregaActualiza(Rol l, string t)
        {
            //Rol l=new Rol;
            //using (SqlConnection conn = new SqlConnection(connec))
            //{
            //    string cadena = "";

            //    if (t == "c")
            //    {
            //        cadena = "SET @i=(SELECT ISNULL(MAX(Id), 0)+1 FROM Rol); " +
            //                 "INSERT INTO Rol(NombreRol) VALUES(@NombreRol);";
            //    }
            //    else if (t == "u")
            //    {
            //        cadena = "UPDATE Rol SET NombreRol = @NombreRol WHERE Id = @Id;";
            //    }

            //    using (SqlCommand cmd = new SqlCommand(cadena, conn))
            //    {
            //        SqlParameter Result = new SqlParameter("@i", SqlDbType.Int)
            //        {
            //            Direction = ParameterDirection.Output
            //        };
            //        cmd.Parameters.Add(Result);

            //        cmd.Parameters.AddWithValue("@Id", l.Id);
            //        cmd.Parameters.AddWithValue("@NombreRol", l.NombreRol);

            //        await conn.OpenAsync();
            //        await cmd.ExecuteNonQueryAsync();

            //        if (t == "c")
            //        {
            //            l.Id = int.Parse(Result.Value.ToString());
            //        }
            //    }
            //}

            return new Rol();
        }
    }
}

