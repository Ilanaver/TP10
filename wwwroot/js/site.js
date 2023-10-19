
    function MostrarJugador(IdJ)
    {
        $.ajax(
            {
                type: 'POST',
                dataType: 'JSON',
                url: '/Home/infoActores',
                data: { IdJugador: IdJ },
                success:
                    function (rasponse){
                        $("#NombreJugador").html(response.nombre);
                        $("#FotoJugador").attr("src", response.foto);
                        $("#EquipoActual").html("Equipo Actual: " + response.equipoActual);
                        $("#FechaNacimiento").html("Fecha de Nacimiento: " + response.fechaNacimiento.substr(0,9));

                    }
            })
    }
