using System.Data.SqlClient;
using Dapper;

public static class BD {
    public static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<Series> MostrarSeries (){
        List<Series> serie = new List<Series>();
        using (var SQL = new SqlConnection(_connectionString))
        {
            serie = SQL.Query<Series>("SELECT * FROM Series").ToList();
        }
        return serie;
    }
    public static List<Actores> ObtenerActores(int serie){
        List<Actores> actores = new List<Actores>();
        using (var SQL = new SqlConnection(_connectionString))
        {
            actores = SQL.Query<Actores>("SELECT * FROM Actores WHERE IdSerie = @pIdSerie", new{@pIdSerie = serie}).ToList();
        }
        return actores;
    }
    
    public static Series ObtenerSerie(int serie){
        using (var SQL = new SqlConnection(_connectionString))
        {
            return SQL.QueryFirstOrDefault<Series>("SELECT * FROM Series WHERE IdSerie = @pIdSerie", new{@pIdSerie = serie});
        }
    }
    public static List<Temporadas> ObtenerTemporadas(int serie){
        List<Temporadas> temporadas = new List<Temporadas>();
        using (var SQL = new SqlConnection(_connectionString))
        {
            temporadas = SQL.Query<Temporadas>("SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie", new{@pIdSerie = serie}).ToList();
        }
        return temporadas;
    }
}