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
                console.log(response)
                $("#Name").html(response.nombre);
                $("#ImagenSerie").attr("src", response.imagenSerie);
                $("#AñoInicio").html("Año de inicio: " + response.añoInicio);
                $("#Sinopsis").html("Sinopsis: " + response.sinopsis);
                
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
            Actor += "Nombre del Actor/actriz: " + element.nombre + "<br>" + "<br>" 
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
            
            response.forEach(element => {
            Tempo += "Numero de Temporada: " + element.numeroTemporada + "<br>";
            Tempo += "Titulo de Temporada: " + element.tituloTemporada + "<br>" + "<br>";
           });
           console.log(Tempo);
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