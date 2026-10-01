var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

var empresa = new { id = 1, codigo = "E001", nombre = "Golazo Huancayo", eslogan = "Tu cancha, tu partido, tu momento", direccion = "Av. Ferrocarril 1234, Huancayo, Junín", telefono = "+51 964 123 456", whatsapp = "51964123456", horarioAtencion = "Lunes a domingo, 08:00 - 23:00" };

var cancha = new { id = 1, codigo = "C001", nombre = "Cancha Golazo", tipo = "Fútbol 7", superficie = "Grass sintético", capacidad = 14, medidas = "40 m x 20 m", iluminacion = true, techada = false, descripcion = "Cancha única de grass sintético con reflectores LED, ideal para partidos entre amigos, entrenamientos y campeonatos." };

var servicios = new[]
{
    new { id = 1, codigo = "S001", nombre = "Alquiler de cancha", categoria = "Principal", descripcion = "Reserva por hora de la cancha de fútbol 7.", precio = 70.0, destacado = true },
    new { id = 2, codigo = "S002", nombre = "Campeonatos", categoria = "Principal", descripcion = "Torneos relámpago y ligas mensuales con premiación.", precio = 350.0, destacado = true },
    new { id = 3, codigo = "S003", nombre = "Entrenamientos", categoria = "Principal", descripcion = "Clases para niños y adultos con entrenadores certificados.", precio = 40.0, destacado = true },
    new { id = 4, codigo = "S004", nombre = "Eventos y cumpleaños", categoria = "Adicional", descripcion = "Paquetes para celebraciones deportivas y corporativas.", precio = 200.0, destacado = false },
    new { id = 5, codigo = "S005", nombre = "Vestuarios y duchas", categoria = "Adicional", descripcion = "Vestuarios con casilleros y agua caliente.", precio = 0.0, destacado = false },
    new { id = 6, codigo = "S006", nombre = "Iluminación nocturna", categoria = "Adicional", descripcion = "Reflectores LED para partidos después de las 18:00.", precio = 10.0, destacado = false },
    new { id = 7, codigo = "S007", nombre = "Estacionamiento", categoria = "Adicional", descripcion = "Zona segura y vigilada para autos y motos.", precio = 0.0, destacado = false },
    new { id = 8, codigo = "S008", nombre = "Alquiler de balón y chalecos", categoria = "Adicional", descripcion = "Balón oficial y set de chalecos por partido.", precio = 8.0, destacado = false }
};

var promociones = new[]
{
    new { id = 1, codigo = "PR001", titulo = "Happy Hour", descripcion = "20% de descuento en horarios de 08:00 a 12:00.", descuento = 20, vigenteHasta = "2026-12-31", activa = true },
    new { id = 2, codigo = "PR002", titulo = "Reserva 4 horas, paga 3", descripcion = "Ideal para entrenamientos y torneos internos.", descuento = 25, vigenteHasta = "2026-11-30", activa = true },
    new { id = 3, codigo = "PR003", titulo = "Cumpleañero gratis", descripcion = "Una hora gratis para el cumpleañero con reserva de grupo.", descuento = 100, vigenteHasta = "2026-10-31", activa = true },
    new { id = 4, codigo = "PR004", titulo = "Promo Fiestas Patrias", descripcion = "Descuento especial por feriado.", descuento = 15, vigenteHasta = "2026-07-31", activa = false }
};

var horarios = new[]
{
    new { id = 1, codigo = "H001", fecha = "2026-10-02", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 2, codigo = "H002", fecha = "2026-10-02", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 3, codigo = "H003", fecha = "2026-10-02", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 4, codigo = "H004", fecha = "2026-10-02", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 5, codigo = "H005", fecha = "2026-10-02", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 6, codigo = "H006", fecha = "2026-10-02", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 7, codigo = "H007", fecha = "2026-10-02", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 8, codigo = "H008", fecha = "2026-10-02", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 9, codigo = "H009", fecha = "2026-10-02", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 10, codigo = "H010", fecha = "2026-10-02", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 11, codigo = "H011", fecha = "2026-10-02", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 12, codigo = "H012", fecha = "2026-10-02", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 13, codigo = "H013", fecha = "2026-10-02", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 14, codigo = "H014", fecha = "2026-10-02", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 15, codigo = "H015", fecha = "2026-10-02", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 16, codigo = "H016", fecha = "2026-10-03", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 17, codigo = "H017", fecha = "2026-10-03", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 18, codigo = "H018", fecha = "2026-10-03", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 19, codigo = "H019", fecha = "2026-10-03", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 20, codigo = "H020", fecha = "2026-10-03", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 21, codigo = "H021", fecha = "2026-10-03", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 22, codigo = "H022", fecha = "2026-10-03", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 23, codigo = "H023", fecha = "2026-10-03", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 24, codigo = "H024", fecha = "2026-10-03", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 25, codigo = "H025", fecha = "2026-10-03", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 26, codigo = "H026", fecha = "2026-10-03", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 27, codigo = "H027", fecha = "2026-10-03", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 28, codigo = "H028", fecha = "2026-10-03", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 29, codigo = "H029", fecha = "2026-10-03", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 30, codigo = "H030", fecha = "2026-10-03", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 31, codigo = "H031", fecha = "2026-10-04", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 32, codigo = "H032", fecha = "2026-10-04", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 33, codigo = "H033", fecha = "2026-10-04", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 34, codigo = "H034", fecha = "2026-10-04", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 35, codigo = "H035", fecha = "2026-10-04", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 36, codigo = "H036", fecha = "2026-10-04", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 37, codigo = "H037", fecha = "2026-10-04", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 38, codigo = "H038", fecha = "2026-10-04", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 39, codigo = "H039", fecha = "2026-10-04", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 40, codigo = "H040", fecha = "2026-10-04", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 41, codigo = "H041", fecha = "2026-10-04", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 42, codigo = "H042", fecha = "2026-10-04", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 43, codigo = "H043", fecha = "2026-10-04", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 44, codigo = "H044", fecha = "2026-10-04", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 45, codigo = "H045", fecha = "2026-10-04", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 46, codigo = "H046", fecha = "2026-10-05", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 47, codigo = "H047", fecha = "2026-10-05", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 48, codigo = "H048", fecha = "2026-10-05", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 49, codigo = "H049", fecha = "2026-10-05", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 50, codigo = "H050", fecha = "2026-10-05", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 51, codigo = "H051", fecha = "2026-10-05", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 52, codigo = "H052", fecha = "2026-10-05", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 53, codigo = "H053", fecha = "2026-10-05", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 54, codigo = "H054", fecha = "2026-10-05", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 55, codigo = "H055", fecha = "2026-10-05", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 56, codigo = "H056", fecha = "2026-10-05", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 57, codigo = "H057", fecha = "2026-10-05", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 58, codigo = "H058", fecha = "2026-10-05", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 59, codigo = "H059", fecha = "2026-10-05", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 60, codigo = "H060", fecha = "2026-10-05", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 61, codigo = "H061", fecha = "2026-10-06", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 62, codigo = "H062", fecha = "2026-10-06", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 63, codigo = "H063", fecha = "2026-10-06", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 64, codigo = "H064", fecha = "2026-10-06", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 65, codigo = "H065", fecha = "2026-10-06", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 66, codigo = "H066", fecha = "2026-10-06", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 67, codigo = "H067", fecha = "2026-10-06", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 68, codigo = "H068", fecha = "2026-10-06", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 69, codigo = "H069", fecha = "2026-10-06", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 70, codigo = "H070", fecha = "2026-10-06", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 71, codigo = "H071", fecha = "2026-10-06", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 72, codigo = "H072", fecha = "2026-10-06", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 73, codigo = "H073", fecha = "2026-10-06", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 74, codigo = "H074", fecha = "2026-10-06", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 75, codigo = "H075", fecha = "2026-10-06", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 76, codigo = "H076", fecha = "2026-10-07", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 77, codigo = "H077", fecha = "2026-10-07", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 78, codigo = "H078", fecha = "2026-10-07", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 79, codigo = "H079", fecha = "2026-10-07", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 80, codigo = "H080", fecha = "2026-10-07", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 81, codigo = "H081", fecha = "2026-10-07", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "mantenimiento", disponible = false },
    new { id = 82, codigo = "H082", fecha = "2026-10-07", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 83, codigo = "H083", fecha = "2026-10-07", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 84, codigo = "H084", fecha = "2026-10-07", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 85, codigo = "H085", fecha = "2026-10-07", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 86, codigo = "H086", fecha = "2026-10-07", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 87, codigo = "H087", fecha = "2026-10-07", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 88, codigo = "H088", fecha = "2026-10-07", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false },
    new { id = 89, codigo = "H089", fecha = "2026-10-07", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 90, codigo = "H090", fecha = "2026-10-07", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "mantenimiento", disponible = false },
    new { id = 91, codigo = "H091", fecha = "2026-10-08", horaInicio = "08:00", horaFin = "09:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 92, codigo = "H092", fecha = "2026-10-08", horaInicio = "09:00", horaFin = "10:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 93, codigo = "H093", fecha = "2026-10-08", horaInicio = "10:00", horaFin = "11:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 94, codigo = "H094", fecha = "2026-10-08", horaInicio = "11:00", horaFin = "12:00", turno = "Mañana", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 95, codigo = "H095", fecha = "2026-10-08", horaInicio = "12:00", horaFin = "13:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 96, codigo = "H096", fecha = "2026-10-08", horaInicio = "13:00", horaFin = "14:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 97, codigo = "H097", fecha = "2026-10-08", horaInicio = "14:00", horaFin = "15:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 98, codigo = "H098", fecha = "2026-10-08", horaInicio = "15:00", horaFin = "16:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 99, codigo = "H099", fecha = "2026-10-08", horaInicio = "16:00", horaFin = "17:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "disponible", disponible = true },
    new { id = 100, codigo = "H100", fecha = "2026-10-08", horaInicio = "17:00", horaFin = "18:00", turno = "Tarde", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 70.0, estado = "reservado", disponible = false },
    new { id = 101, codigo = "H101", fecha = "2026-10-08", horaInicio = "18:00", horaFin = "19:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 102, codigo = "H102", fecha = "2026-10-08", horaInicio = "19:00", horaFin = "20:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 103, codigo = "H103", fecha = "2026-10-08", horaInicio = "20:00", horaFin = "21:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "mantenimiento", disponible = false },
    new { id = 104, codigo = "H104", fecha = "2026-10-08", horaInicio = "21:00", horaFin = "22:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "disponible", disponible = true },
    new { id = 105, codigo = "H105", fecha = "2026-10-08", horaInicio = "22:00", horaFin = "23:00", turno = "Noche", duracionMinutos = 60, tipoCancha = "Fútbol 7", precio = 90.0, estado = "reservado", disponible = false }
};

app.MapGet("/", () =>
{
    return "API Cancha de futbol funcionando";
});

app.MapGet("/api/CanchaFutbol", () =>
{
    return Results.Ok(horarios);
});

app.MapGet("/api/CanchaFutbol/{id:int}", (int id) =>
{
    var horario = horarios.FirstOrDefault(h => h.id == id);
    return horario is null
        ? Results.NotFound(new { mensaje = "Horario no encontrado" })
        : Results.Ok(horario);
});

app.MapGet("/api/cancha", () => Results.Ok(cancha));

app.MapGet("/api/empresa", () => Results.Ok(empresa));

app.MapGet("/api/servicios", () => Results.Ok(servicios));

app.MapGet("/api/promociones", () => Results.Ok(promociones));

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Run($"http://0.0.0.0:{port}");