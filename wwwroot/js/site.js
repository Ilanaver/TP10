function MostrarSerie(IdS) 
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/infoSerie',
            data: {IdSerie : IdS},
            success:
            function(response)
        {
            $("#Name").html(response.Nombre);
            $("#ImagenSerie").attr("src", response.ImagenSerie);
            $("#AñoInicio").html("Año de inicio: " + response.AñoInicio);
            $("#Sinopsis").html("Sinopsis: " +response.Sinopsis);
            TemporadaFunc();
            ActoresFunc();
        }
        }
        
    )
    
}

function MostrarActores(IdS) 
{
    let Actor = "";
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/infoActores',
            data: {IdSerie : IdS},
            success:
            function(response)
        {
            response.forEach(element => {
            Actor += "Nombre del Actor/actriz: " + element.Nombre + "<br>" + "<br>" 
           });

           $("#Actores").html(Actor);
           InfoSerieFunc();
           TemporadaFunc();
        }
        }
        
    )
    
}

function MostrarTemporadas(IdS) 
{
    let Tempo = "";
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/infoTemporadas',
            data: {IdSerie : IdS},
            success:
            function(response)
        {
            hello.forEach(element => {
            Tempo += "Numero de Temporada: " + element.NumeroTemporada + "<br>";
            Tempo += "Titulo de Temporada: " + element.TituloTemporada + "<br>" + "<br>";
           });

           $("#Temporadas").html(Tempo);
           
        }
        }
        
    )
    
}
function InfoSerieFunc() {
    $("AñoInicio").html("");
    $("Sinopsis").html("");
}
function TemporadaFunc() {
    $("Temporadas").html("");
}
function ActoresFunc() {
    $("Actores").html("");
}