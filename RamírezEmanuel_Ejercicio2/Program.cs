Console.WriteLine("Seleccione su Rol:");
Console.WriteLine("");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Técnico IT");
Console.WriteLine("4. Visistante");
Console.WriteLine("");
int rol=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la hora de ingreso (0-23): ");
Console.WriteLine("");
int hora=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingres el número de día (1-7): ");
Console.WriteLine("");
int dia=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Tiene un carnet vigente? (s/n)");
Console.WriteLine("");
string carne=Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Tiene autorización escrita? (s/n)");
Console.WriteLine("");
string autorizacion = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Trae una USB? (s/n)");
Console.WriteLine("");
string usb=Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Está acompañado? (s/n)");
Console.WriteLine("");
string compania = Console.ReadLine();
Console.WriteLine("");
if (hora>=0 && hora<=23 && dia>=1 && dia <=7 && (carne=="s" || carne=="n") && (autorizacion=="s" || autorizacion=="n") && (usb=="s" || usb=="n") && (compania=="s" || compania == "n"))
{
   switch (rol)
    {
        case 1:
            Console.WriteLine("");
            break;
            case 2:
            Console.WriteLine("");
            break;
            case 3:
            Console.WriteLine("");
            break;
            case 4:
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Rol no válido");
            break;
    }
}
else
{
    Console.WriteLine("Datos inválidos");
    Console.WriteLine("Por favor ingrese datos que sean válidos");
}
