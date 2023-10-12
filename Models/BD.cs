using System.Data.SqlClient;
using Dapper;

public static class BD {
    public static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";
    
    public static List<Actores> ObtenerActores(int serie){
        List<Actores> actores = new List<Actores>();
        using (var SQL = new SqlConnection(_connectionString))
        {
            actores = SQL.Query<Actores>("SELECT * FROM Actores WHERE IdSerie = @pIdSerie", new{serie = @pIdSerie}).ToList();
        }
        return actores;
    }
    
    public static List<Serie> ObtenerSeries(){
        List<Serie> series = new List<Serie>();
        using (var SQL = new SqlConnection(_connectionString))
        {
            series = SQL.Query<Serie>("SELECT * FROM Serie").ToList();
        }
        return series;
    }
}