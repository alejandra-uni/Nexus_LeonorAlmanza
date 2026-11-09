//Aqui comienza el programa :D
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

class Cadete
{
    private string nombre;
    private int edad;
    private int energia;
    private int estabilidad;
    private string realidad;

   
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public int Energia
    {
        get { return energia; }
        set
        {
            energia = value;

            if (energia < 0)
                energia = 0;

            if (energia > 100)
                energia = 100;
        }
    }

    public int Estabilidad
    {
        get { return estabilidad; }
        set
        {
            estabilidad = value;

            if (estabilidad < 0)
                estabilidad = 0;

            if (estabilidad > 100)
                estabilidad = 100;
        }
    }

    public string Realidad
    {
        get { return realidad; }
        set { realidad = value; }
    }

    // Constructor
    public Cadete(string nombre, int edad, string realidad, int energia, int estabilidad)
    {
        Nombre = nombre;
        Edad = edad;
        Realidad = realidad;
        Energia = energia;
        Estabilidad = estabilidad;
    }

    // Método para recuperar energía :o
    public void RecuperarEnergia()
    {
        Energia += 20;

        if (Energia > 100)
            Energia = 100;
    }

    
    public void GastarEnergia(int cantidad)
    {
        Energia -= cantidad;

        if (Energia < 0)
            Energia = 0;
    }

   
    public void AumentarEstabilidad(int cantidad)
    {
        Estabilidad += cantidad;

        if (Estabilidad > 100)
            Estabilidad = 100;
    }

    
    public void ReducirEstabilidad(int cantidad)
    {
        Estabilidad -= cantidad;

        if (Estabilidad < 0)
            Estabilidad = 0;
    }

    // Método para mostrar el estado
    public void MostrarEstado()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Realidad: " + Realidad);
        Console.WriteLine("Energía: " + Energia);
        Console.WriteLine("Estabilidad: " + Estabilidad);
    }
}



// Esta clase permite establecer una relación entre objetos Cadete.
// SistemaNexus contiene un cadete principal y un cadete de respaldo.
class SistemaNexus
{
    private Cadete cadetePrincipal;
    private Cadete cadeteRespaldo;

    //  CONSTRUCTOR
    public SistemaNexus(Cadete cadetePrincipal, Cadete cadeteRespaldo)
    {
        this.cadetePrincipal = cadetePrincipal;
        this.cadeteRespaldo = cadeteRespaldo;
    }

    //  MÉTODO
    public void MostrarCadetes()
    {
        Console.WriteLine("Cadete principal: " + cadetePrincipal.Nombre);
        Console.WriteLine("Cadete de respaldo: " + cadeteRespaldo.Nombre);
    }

    //  MÉTODO PARA OBTENER EL CADETE PRINCIPAL
    public Cadete ObtenerCadetePrincipal()
    {
        return cadetePrincipal;
    }

    // MÉTODO PARA OBTENER EL CADETE DE RESPALDO
    public Cadete ObtenerCadeteRespaldo()
    {
        return cadeteRespaldo;
    }
}


class Nexus
{
    static void Main()
    {
        //Estas variables guardaran los datos, se pueden renombrar         
        string nombre_UuU;
        int edad;
        string realidad;
        int energía;
        int estabilidad;

        // MAPAS AÑADIDO        
        // Arreglo que almacena las realidades disponibles        
        string[] realidades = { "IRIS-07", "IRIS-12", "IRIS-21" };
        // FIN MAPAS AÑADIDO        

        //conexíon(no mover UnU)"???"        
        bool conectado = false;

        //Título        
        Console.Title = "Nexus Training System";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
        Console.WriteLine("≈                       /  O   O   /                 B I E N V E N I D O_ A         / ⌃   ⌃  /                        ≈");
        Console.WriteLine("≈                      /    o     /             *  A   N   E   X   U   S  *        /   V    /                         ≈");
        Console.WriteLine("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("        SISTEMA DE ENTRENAMIENTO Y EXPLORACIÓN     ");
        Console.WriteLine("               CON MAPAS DE REALIDADES             ");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("            Inicializando sistema NEXUS...         ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("INICIALIZANDO: [");

        for (int i = 0; i < 20; i++)
        {
            Console.Write("#");
            System.Threading.Thread.Sleep(50);
        }

        Console.WriteLine("] 100%");
        Console.ResetColor();

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(">> SISTEMA NEXUS LISTO.");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        Console.Clear();

        //Título        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("************************************************IIIIILIEIOINIOIRIIIII**************************************************");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("************************************************Nexus Training System**************************************************");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("************************************************IIIIAILIMIAINIZIAIIII**************************************************");

        Console.ResetColor();
        Console.WriteLine();

        Console.Write("Ingresar el nombre_UuU: ");
        nombre_UuU = Console.ReadLine();

        Console.Write("Ingresar la edad: ");
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.WriteLine("Error. Ingresar la edad nuevamente.");
            Console.Write("de nuevo pon la edad correctamente :D :");
        }

        Console.Write("Ingrese la realidad UuU: ");
        realidad = Console.ReadLine();

        Console.Write("Ingrese nivel de energía (0-100): ");
        while (!int.TryParse(Console.ReadLine(), out energía) || energía < 0)
        {
            Console.WriteLine("La energía debe estar entre 0 y 100.");
            Console.Write("ingresa de nuevo la energía: ");
        }

        Console.Write("Ingrese estabilidad de conexión (0-100): ");
        while (!int.TryParse(Console.ReadLine(), out estabilidad) || estabilidad < 0)
        {
            Console.WriteLine("La estabilidad debe estar entre 0 y 100.");
            Console.Write("ingresa de nuevo la estabilidad UnU: ");
        }

        // OBJETOS DE LA CLASE CADETE
        Cadete cadete1 = new Cadete(
            nombre_UuU,
            edad,
            realidad,
            energía,
            estabilidad
        );

        Cadete cadete2 = new Cadete(
            "Cadete de respaldo",
            20,
            "IRIS-12",
            80,
            80
        );

        //  POO AGREGADO: RELACIÓN ENTRE OBJETOS
        SistemaNexus sistemaNexus = new SistemaNexus(cadete1, cadete2);

        Console.WriteLine();
        Console.WriteLine("NEXUS está CARGANDO, esperar UwU no tardara");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("NEXUS: [");

        for (int i = 0; i < 20; i++)
        {
            Console.Write("#");
            System.Threading.Thread.Sleep(50);
        }

        Console.WriteLine("] 100%");
        Console.ResetColor();
        Console.WriteLine();

        // CONEXIÓN usando el objeto cadete1
        if (cadete1.Edad >= 18 && cadete1.Energia >= 40 && cadete1.Estabilidad >= 50)
        {
            conectado = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("INMERSIÓN AUTORIZADA");
            Console.ResetColor();

            Console.WriteLine("Cadete: " + cadete1.Nombre);
            Console.WriteLine("NEXUS ha establecido la conexión :D.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INMERSIÓN RECHAZADA");
            Console.ResetColor();

            Console.WriteLine("Los datos requeridos no paso, insuficiente UnU.");
        }

        // Ciclo while (repetira la secuencia)        
        while (conectado)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*****L*E*O*N*O*R*****");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("NEXUS TRAINING SYSTEM");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****A*L*M*A*N*Z*A****");

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("EXPLORADOR: " + nombre_UuU);
            Console.WriteLine("REALIDAD:   " + realidad);
            Console.WriteLine("ENERGÍA:    " + energía);
            Console.WriteLine("ESTABILIDAD:" + estabilidad);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Menú de opciones c: ");
            Console.ResetColor();

            Console.WriteLine("1. Explorar realidad");
            Console.WriteLine("2. Analizar anomalía");
            Console.WriteLine("3. Consultar estado");
            Console.WriteLine("4. Recuperar energía");
            Console.WriteLine("5. Intentar desconexión");
            Console.WriteLine("6. Mapas de realidades");
            Console.WriteLine("7. Conexión en red");
            Console.WriteLine("8. Consultar cadetes");

            Console.Write("Seleccione una operación: ");
            string opcion = Console.ReadLine();

            Console.WriteLine();

            switch (opcion)
            {
                case "1":

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("*****************L*E*O*N*O*R******************");
                    Console.WriteLine("          NEXUS - EXPLORACIÓN ACTIVADO        ");
                    Console.WriteLine("*****************A*L*M*A*N*Z*A****************");
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.WriteLine("CADETE: " + nombre_UuU);
                    Console.WriteLine("DESTINO: " + realidad);
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(">>Vehículo de Exploración preparado<<");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(">>Desplazando Vehículo<<: [");

                    int filaBus = Console.CursorTop + 1;

                    for (int i = 0; i <= 20; i++)
                    {
                        Console.CursorLeft = 25;
                        Console.Write(new string('#', i));
                        Console.Write(new string(' ', 20 - i));
                        Console.Write("] " + (i * 5) + "%");

                        Console.CursorLeft = 0;
                        Console.CursorTop = filaBus;

                        string espacios = new string(' ', i * 2);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(espacios + "      _________________     ");
                        Console.WriteLine(espacios + "     |         |⌃  ⌃|  |    ");
                        Console.WriteLine(espacios + " ____|         |  V  | |____");
                        Console.WriteLine(espacios + "|    |_________________|   |");
                        Console.WriteLine(espacios + "|                          |");
                        Console.WriteLine(espacios + "|__________________________|");
                        Console.WriteLine(espacios + "     ()               ()    ");
                        Console.ResetColor();

                        System.Threading.Thread.Sleep(80);
                    }

                    Console.CursorLeft = 25;
                    Console.Write(new string('#', 20) + "] 100%");
                    Console.CursorTop = filaBus + 8;
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine();

                    Console.WriteLine(">> ATRAVESANDO PORTAL...");
                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine(">> INGRESANDO A " + realidad + "...");
                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine(">> ESCANEANDO TERRENO...");
                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine();

                    if (realidad == "IRIS-07")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(">> ESCÁNER: Se detectaron cristales de energía UuU.");
                        Console.ResetColor();
                    }
                    else if (realidad == "IRIS-12")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(">> ESCÁNER: Se detectaron señales desconocidas :O.");
                        Console.ResetColor();
                    }
                    else if (realidad == "IRIS-21")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(">> ESCÁNER: Se detectaron interferencias qwq.");
                        Console.ResetColor();
                    }

                    Console.WriteLine();

                    if (energía >= 40 && estabilidad >= 60)
                    {
                        energía -= 15;
                        estabilidad -= 5;

                        cadete1.Energia = energía;
                        cadete1.Estabilidad = estabilidad;

                        Console.WriteLine("Exploración Segura.");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("* EXPLORACIÓN HECHA :D*");
                        Console.ResetColor();
                    }
                    else if (energía >= 15 && estabilidad >= 30)
                    {
                        energía -= 15;
                        estabilidad -= 10;

                        cadete1.Energia = energía;
                        cadete1.Estabilidad = estabilidad;

                        Console.WriteLine("Exploración Inestable (puede haber interferencias UnU).");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("* EXPLORACIÓN HECHA CON INESTABILIDAD U_U*");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Exploración Rechazada UnU");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("* EXPLORACIÓN NO COMPLETADA :C *");
                        Console.ResetColor();
                    }

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FINALIZANDO OPERACIÓN: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.WriteLine(">> OPERACIÓN COMPLETADA.");
                    Console.ResetColor();

                    break;

                case "2":

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("ANALIZANDO ANOMALÍA: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(60);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    if (energía >= 10)
                    {
                        energía -= 10;

                        cadete1.Energia = energía;

                        if (estabilidad <= 60)
                        {
                            estabilidad += 15;

                            if (estabilidad > 100)
                                estabilidad = 100;

                            cadete1.Estabilidad = estabilidad;

                            Console.WriteLine("Análisis completado.");
                            Console.WriteLine("La estabilidad aumentó 15 puntos.");
                        }
                        else
                        {
                            Console.WriteLine("No se detectaron anomalías importantes.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("NEXUS: Energía insuficiente para realizar el análisis.");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FINALIZANDO ANÁLISIS: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.WriteLine(">> ANÁLISIS FINALIZADO.");
                    Console.ResetColor();

                    break;

                case "3":

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("CONSULTANDO ESTADO: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(50);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("ESTADO DEL EXPLORADOR MUY IMPORTANTE");
                    Console.ResetColor();

                    Console.WriteLine("Nombre: " + nombre_UuU);
                    Console.WriteLine("Realidad: " + realidad);
                    Console.WriteLine("Edad: " + edad);
                    Console.WriteLine("Energía: " + energía);
                    Console.WriteLine("Estabilidad: " + estabilidad);

                    Console.Write("ENERGÍA:     [");

                    for (int i = 0; i < energía / 5; i++)
                    {
                        Console.Write("#");
                    }

                    for (int i = energía / 5; i < 20; i++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine("]");

                    Console.Write("ESTABILIDAD: [");

                    for (int i = 0; i < estabilidad / 5; i++)
                    {
                        Console.Write("#");
                    }

                    for (int i = estabilidad / 5; i < 20; i++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine("]");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("ESTADO ACTUALIZADO: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    break;

                case "4":

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("RECUPERANDO ENERGÍA: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(50);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    energía += 20;

                    if (energía > 100)
                        energía = 100;

                    cadete1.Energia = energía;

                    Console.WriteLine("Recuperación de energía iniciada");
                    Console.WriteLine("Energía actual: " + energía);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("RECUPERACIÓN COMPLETADA: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    break;

                case "5":

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("DESCONECTANDO NEXUS: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(50);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    Console.WriteLine("Desconexión iniciada");
                    Console.WriteLine("Simulación finalizada.");
                    conectado = false;

                    break;

                // MAPAS DE REALIDADES        
                case "6":

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("CARGANDO CARTOGRAFÍA: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(50);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("#############L#E#O#N#O#R#################");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("#      Nexus  / Mapas de Realidades     #");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("###########A#L#M#A#N#Z#A#################");
                    Console.ResetColor();

                    Console.WriteLine("# [1] IRIS-07 // Valle de Cristal       #");
                    Console.WriteLine("# [2] IRIS-12 // Sector Abisal          #");
                    Console.WriteLine("# [3] IRIS-21 // Zona de Interferencia  #");
                    Console.WriteLine("#########################################");
                    Console.WriteLine();

                    Console.Write("Seleccione una realidad: ");
                    string seleccionMapa = Console.ReadLine();

                    // Matriz que almacenará el mapa seleccionado        
                    int[,] mapa;

                    // MAPA 1 - IRIS-07        
                    if (seleccionMapa == "1")
                    {
                        realidad = realidades[0];

                        mapa = new int[,]
                        {
                            { 1, 1, 1, 1, 0, 1, 0, 0 },
                            { 1, 1, 3, 1, 1, 1, 1, 0 },
                            { 1, 1, 1, 3, 2, 0, 0, 0 },
                            { 1, 0, 0, 0, 3, 1, 0, 0 },
                            { 1, 1, 1, 1, 0, 0, 0, 0 },
                            { 1, 4, 1, 1, 0, 0, 0, 0 }
                        };
                    }

                    // MAPA 2 - IRIS-12        
                    else if (seleccionMapa == "2")
                    {
                        realidad = realidades[1];

                        mapa = new int[,]
                        {
                            { 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 1, 1, 3, 1, 1, 0, 0 },
                            { 0, 1, 4, 1, 3, 4, 0, 0 },
                            { 0, 1, 1, 3, 2, 1, 0, 0 },
                            { 0, 0, 0, 1, 1, 1, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0 }
                        };
                    }

                    // MAPA 3 - IRIS-21        
                    else if (seleccionMapa == "3")
                    {
                        realidad = realidades[2];

                        mapa = new int[,]
                        {
                            { 1, 1, 0, 3, 1, 1, 0, 0 },
                            { 1, 3, 3, 1, 0, 0, 0, 0 },
                            { 1, 1, 1, 2, 4, 0, 0, 0 },
                            { 0, 0, 0, 1, 0, 0, 1, 1 },
                            { 0, 0, 4, 0, 1, 1, 1, 1 },
                            { 0, 0, 0, 0, 0, 1, 1, 1 }
                        };
                    }
        
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Realidad no válida.");
                        Console.WriteLine("Seleccione 1, 2 o 3.");

                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();

                        break;
                    }

                    cadete1.Nombre = nombre_UuU;
                    cadete1.Realidad = realidad;
                    cadete1.Edad = edad;
                    cadete1.Energia = energía;
                    cadete1.Estabilidad = estabilidad;

                    // Código de movimiento
                    int filas = 6, columnas = 8;
                    int jugFila = 0, jugCol = 0;
                    int recolectados = 0;
                    const int META = 3;
                    bool[,] recogido = new bool[filas, columnas];
                    bool explorando = true;

                    Console.CursorVisible = false;

                    // Colocar al jugador en la Base (donde mapa = 2)
                    for (int f = 0; f < filas; f++)
                        for (int c = 0; c < columnas; c++)
                            if (mapa[f, c] == 2)
                            {
                                jugFila = f;
                                jugCol = c;
                            }

                    while (explorando)
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("/////L/E/O/N/O/R/////");
                        Console.ResetColor();

                        Console.WriteLine("NEXUS / EXPLORACIÓN ACTIVA");
                        Console.WriteLine("REALIDAD: " + realidad);

                        Console.Write("   ");

                        for (int c = 0; c < columnas; c++)
                            Console.Write(c + " ");

                        Console.WriteLine("\n");

                        for (int f = 0; f < filas; f++)
                        {
                            Console.Write(f + "  ");

                            for (int c = 0; c < columnas; c++)
                            {
                                if (f == jugFila && c == jugCol)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("■ ");
                                    Console.ResetColor();
                                    continue;
                                }

                                if (recogido[f, c])
                                {
                                    Console.Write("≈ ");
                                    continue;
                                }

                                switch (mapa[f, c])
                                {
                                    case 0:
                                        Console.Write("≈ ");
                                        break;

                                    case 1:
                                        Console.Write("■ ");
                                        break;

                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("⌂ ");
                                        Console.ResetColor();
                                        break;

                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("* ");
                                        Console.ResetColor();
                                        break;

                                    case 4:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("! ");
                                        Console.ResetColor();
                                        break;
                                }
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("\nRECURSOS: " + recolectados + "/" + META);
                        Console.WriteLine("↑↓←→ Mover  |  ESC Salir");

                        ConsoleKeyInfo tecla = Console.ReadKey(true);

                        int nf = jugFila, nc = jugCol;

                        switch (tecla.Key)
                        {
                            case ConsoleKey.UpArrow:
                                nf--;
                                break;

                            case ConsoleKey.DownArrow:
                                nf++;
                                break;

                            case ConsoleKey.LeftArrow:
                                nc--;
                                break;

                            case ConsoleKey.RightArrow:
                                nc++;
                                break;

                            case ConsoleKey.Escape:
                                explorando = false;
                                break;
                        }

                        if (!explorando)
                            break;

                        if (nf < 0 || nf >= filas || nc < 0 || nc >= columnas)
                            continue;

                        if (mapa[nf, nc] == 0)
                        {
                            Console.WriteLine("No puedes cruzar el agua!");
                            System.Threading.Thread.Sleep(500);
                            continue;
                        }

                        jugFila = nf;
                        jugCol = nc;

                        // Recolectar recurso
                        if (mapa[jugFila, jugCol] == 3 && !recogido[jugFila, jugCol])
                        {
                            recogido[jugFila, jugCol] = true;
                            recolectados++;

                            energía -= 5;
                            cadete1.Energia = energía;

                            if (recolectados >= META)
                            {
                                Console.WriteLine("¡MISIÓN COMPLETADA!");
                                explorando = false;
                            }
                        }

                        // Anomalía
                        if (mapa[jugFila, jugCol] == 4)
                        {
                            Console.WriteLine("¡ANOMALÍA! Estabilidad baja");

                            estabilidad -= 5;
                            cadete1.Estabilidad = estabilidad;

                            System.Threading.Thread.Sleep(600);
                        }
                    }

                    Console.CursorVisible = true;

                    Console.WriteLine("Presiona una tecla...");
                    Console.ReadKey();

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("/////L/E/O/N/O/R/////");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" Nexus / Cartografia ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("////A/L/M/A/N/Z/A////");
                    Console.ResetColor();

                    Console.WriteLine("REALIDAD: " + realidad);
                    Console.WriteLine();

                    // CONTADORES        
                    int recursos = 0;
                    int anomalias = 0;

                    int posicionesTotales =
                        mapa.GetLength(0) * mapa.GetLength(1);

                    int posicionesRegistradas = 0;

                    // NÚMEROS DE LAS COLUMNAS        
                    Console.Write("    ");

                    for (int columna = 0;
                         columna < mapa.GetLength(1);
                         columna++)
                    {
                        Console.Write(columna + " ");
                    }

                    Console.WriteLine();

                    // CICLO PARA RECORRER LAS FILAS        
                    for (int fila = 0;
                         fila < mapa.GetLength(0);
                         fila++)
                    {
                        Console.Write(fila + " | ");

                        for (int columna = 0;
                             columna < mapa.GetLength(1);
                             columna++)
                        {
                            int estado = mapa[fila, columna];

                            if (estado == 0)
                            {
                                Console.Write("≈ ");
                            }
                            else if (estado == 1)
                            {
                                Console.Write("■ ");
                            }
                            else if (estado == 2)
                            {
                                Console.Write("⌂ ");
                            }
                            else if (estado == 3)
                            {
                                Console.Write("* ");
                                recursos++;
                            }
                            else if (estado == 4)
                            {
                                Console.Write("? ");
                                anomalias++;
                            }

                            if (estado != 0)
                            {
                                posicionesRegistradas++;
                            }
                        }

                        Console.WriteLine();
                    }

                    // CALCULAR PORCENTAJE DE CARTOGRAFÍA        
                    double porcentajeCartografia =
                        (double)posicionesRegistradas
                        / posicionesTotales
                        * 100;

                    // INFORMACIÓN DEL MAPA        
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("//INFORMACIÓN DEL MAPA//");
                    Console.ResetColor();

                    Console.WriteLine("REALIDAD: " + realidad);

                    Console.WriteLine(
                        "RECURSOS DETECTADOS: " + recursos);

                    Console.WriteLine(
                        "ANOMALÍAS DETECTADAS: " + anomalias);

                    Console.WriteLine(
                        "CARTOGRAFÍA: " +
                        porcentajeCartografia.ToString("0") + "%");

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("LEYENDA:");
                    Console.ResetColor();

                    Console.WriteLine("■ = Terreno");
                    Console.WriteLine("≈ = Agua");
                    Console.WriteLine("⌂ = Base");
                    Console.WriteLine("* = Recurso");
                    Console.WriteLine("? = Anomalía");

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MAPA CARTOGRAFIADO CORRECTAMENTE.");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FINALIZANDO CARTOGRAFÍA: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.WriteLine(">> CARTOGRAFÍA COMPLETADA.");
                    Console.ResetColor();

                    Console.WriteLine();

                    Console.WriteLine("Presione una tecla para volver al menú...");
                    Console.ReadKey();

                    break;

                case "7":

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("+             CONEXIÓN EN RED NEXUS            +");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("INICIANDO MÓDULO DE RED: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(50);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.WriteLine("1. Crear conexión");
                    Console.WriteLine("2. Unirse a una conexión");
                    Console.WriteLine("3. Cancelar");

                    Console.WriteLine();
                    Console.Write("Seleccione una opción: ");

                    string opcionRed = Console.ReadLine();

                    int puerto = 5000;

                    if (opcionRed == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine("NEXUS está esperando a otro explorador...");
                        Console.WriteLine("Puerto utilizado: " + puerto);
                        Console.WriteLine();

                        try
                        {
                            TcpListener servidor =
                                new TcpListener(IPAddress.Any, puerto);

                            servidor.Start();

                            Console.WriteLine("Servidor NEXUS iniciado.");
                            Console.WriteLine("Esperando conexión del compañero...");
                            Console.WriteLine();

                            bool encontroConexion = false;

                            for (int tiempo = 0; tiempo < 30; tiempo++)
                            {
                                if (servidor.Pending())
                                {
                                    TcpClient cliente =
                                        servidor.AcceptTcpClient();

                                    encontroConexion = true;

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                    Console.WriteLine("                  ¡CONEXIÓN CON OTRO EXPLORADOR! UuU             ");
                                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                    Console.ResetColor();

                                    cliente.Close();
                                    break;
                                }

                                Console.Write(".");
                                System.Threading.Thread.Sleep(1000);
                            }

                            servidor.Stop();

                            Console.WriteLine();

                            if (!encontroConexion)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("No se encontró ningún compañero.");
                                Console.WriteLine("La misión de red se mantiene opcional.");
                                Console.ResetColor();
                            }
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No se pudo iniciar la conexión de red.");
                            Console.WriteLine("Puedes continuar usando NEXUS normalmente.");
                            Console.ResetColor();
                        }
                    }
                    else if (opcionRed == "2")
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese la IP del compañero: ");

                        string ipCompañero = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Intentando establecer conexión...");
                        Console.WriteLine();

                        try
                        {
                            TcpClient cliente = new TcpClient();

                            IAsyncResult resultado =
                                cliente.BeginConnect(
                                    ipCompañero,
                                    puerto,
                                    null,
                                    null);

                            bool conectadoRed =
                                resultado.AsyncWaitHandle.WaitOne(5000);

                            if (conectadoRed)
                            {
                                cliente.EndConnect(resultado);

                                Console.ForegroundColor =
                                    ConsoleColor.DarkRed;

                                Console.WriteLine("///////////////////////////////////////////////////////////////");
                                Console.WriteLine("               ¡CONEXIÓN NEXUS ESTABLECIDA! :D                 ");
                                Console.WriteLine("///////////////////////////////////////////////////////////////");

                                Console.ResetColor();

                                cliente.Close();
                            }
                            else
                            {
                                Console.ForegroundColor =
                                    ConsoleColor.Yellow;

                                Console.WriteLine(
                                    "No se encontró al compañero.");

                                Console.WriteLine(
                                    "Puedes continuar usando NEXUS sin conexión.");

                                Console.ResetColor();

                                cliente.Close();
                            }
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor =
                                ConsoleColor.Red;

                            Console.WriteLine(
                                "No se pudo establecer la conexión.");

                            Console.WriteLine(
                                "Compruebe la IP y que el otro explorador");

                            Console.WriteLine(
                                "tenga iniciada la opción 'Crear conexión'.");

                            Console.ResetColor();

                            Console.WriteLine();

                            Console.ForegroundColor =
                                ConsoleColor.Yellow;

                            Console.WriteLine(
                                "NEXUS continúa funcionando de manera local.");

                            Console.ResetColor();
                        }
                    }
                    else if (opcionRed == "3")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Conexión en red cancelada.");
                        Console.WriteLine("Regresando al menú de NEXUS...");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción de red inválida.");
                        Console.ResetColor();
                    }

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("FINALIZANDO MÓDULO DE RED: [");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.WriteLine(">> MÓDULO DE RED FINALIZADO.");
                    Console.ResetColor();

                    break;

                case "8":

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("============L=E=O=N=O=R=================");
                    Console.WriteLine("          ENTIDADES CADETE");
                    Console.WriteLine("===========A=L=M=A=N=Z=A==============");
                    Console.ResetColor();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("CADETE 1");
                    Console.ResetColor();

                    cadete1.MostrarEstado();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("CADETE 2");
                    Console.ResetColor();

                    cadete2.MostrarEstado();

                    Console.WriteLine();

                    // El objeto SistemaNexus está relacionado con los dos objetos Cadete.
                    sistemaNexus.MostrarCadetes();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Los objetos Cadete funcionan correctamente.");
                    Console.ResetColor();

                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operación inválida.");
                    Console.ResetColor();

                    Console.WriteLine("Seleccione una opción del 1 al 7.");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("PROCESANDO: ");

                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write("#");
                        System.Threading.Thread.Sleep(30);
                    }

                    Console.WriteLine("] 100%");
                    Console.ResetColor();

                    break;
            }

            // REGLAS NUEVAS DE NEXUS MISION 2        

            // REGLA 1: Estado general        
            if (energía >= 70 && estabilidad >= 70)
            {
                Console.WriteLine("Estado del sistema Óptimo :D.");
            }
            else if (energía >= 40 && estabilidad >= 40)
            {
                Console.WriteLine("Estado del sistema Estable UuU.");
            }
            else
            {
                Console.WriteLine("Estado del sistema en ADVERTENCIA :O.");
            }

            // REGLA 2: Advertencia por recursos bajos        
            if (energía < 30 || estabilidad < 30)
            {
                Console.WriteLine(
                    "ADVERTENCIA. Uno de los recursos está en nivel bajo UnU.");
            }

            // REGLA 3: Situación de exploración peligrosa        
            if (energía < 20 && estabilidad < 40)
            {
                Console.WriteLine(
                    "La realidad presenta condiciones peligrosas D: .");
            }

            // REGLA 4: Conexión inestable        
            if (conectado && estabilidad <= 40)
            {
                Console.WriteLine(
                    "La conexión presenta inestabilidad.");
            }

            if (conectado && estabilidad <= 30 && energía <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">>>>>>>>L>E>O>N>O>R>>>>>>>>>");
                Console.WriteLine("ALERTA DE INTERFERENCIA IRIS");
                Console.WriteLine("<<<<<<<<A<L<M<A<N<Z<A<<<<<<<");
                Console.ResetColor();

                Console.WriteLine(
                    "La estabilidad de la realidad está en un nivel critico");

                Console.WriteLine(
                    "NEXUS recomienda desconexión inmediata");

                Console.WriteLine(
                    "Energía y estabilidad en niveles peligrosos.");

                Console.WriteLine(
                    "IRIS intentará estabilizar la conexión UuU.");

                estabilidad += 10;
                energía -= 5;

                if (energía < 0)
                {
                    energía = 0;
                }

                Console.WriteLine(
                    "IRIS ha modificado el estado de la realidad.");

                Console.WriteLine(
                    "Estabilidad +10 y Energía -5");

                if (estabilidad <= 30)
                {
                    Console.WriteLine(
                        "La estabilización ha FALLADO D:.");

                    Console.WriteLine(
                        "NEXUS finalizará automáticamente la sesión.");

                    conectado = false;
                }
                else
                {
                    Console.WriteLine(
                        "La conexión se establecio :D.");
                }
            }

            if (!conectado)
            {
                Console.WriteLine(
                    "La conexión ya no está activa.");
            }

            Console.WriteLine(
                "-CONEXIÓN NEXUS FINALIZADA UuU-");

            Console.WriteLine(
                "Fin de la simulación.");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("FINALIZANDO SESIÓN NEXUS: [");

            for (int i = 0; i < 20; i++)
            {
                Console.Write("#");
                System.Threading.Thread.Sleep(50);
            }

            Console.WriteLine("] 100%");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("             SESIÓN NEXUS FINALIZADA            ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(">> Todos los procesos han terminado.");
            Console.WriteLine(">> Gracias por utilizar NEXUS.");
            Console.ResetColor();
        }
    }
}