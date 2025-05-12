Console.Clear();

double lado1 = 3, lado2 = 4, lado3 = 5; //colocar opção de digitação

if (!ExisteTriangulo(lado1, lado2, lado3))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Não é triangulo!");
    Console.ResetColor();
}

else 
{
    string tipo = TipoTriangulo(lado1, lado2, lado3);
    double area = AreaTriangulo(lado1, lado2, lado3);

    Console.WriteLine($"O triângulo é {tipo} e possui área de {area}");
}

Console.WriteLine();




static bool ExisteTriangulo(double a, double b, double c) //aqui n pode fazer a simplificação da vírgula, precisa declarar
{
    bool trianguloValido = (
        a > 0 && b > 0 && c > 0
        && a < (b + c)
        && b < (a + c)
        && c < (a + b)
        && a > Math.Abs(b - c)
        && b > Math.Abs(a - c)
        && c > Math.Abs(a - b)
    );
    return trianguloValido;
}

static string TipoTriangulo(double a, double b, double c)
{
    if(a == b && b == c)
    {
        return "Equilátero";
    }

    else if(a != b && b!= c && a != c)
    {
        return "Escaleno";
    }

    else
    {
        return "Isósceles";
    }
}

static double AreaTriangulo (double a, double b, double c)
{
    double s = (a + b + c) / 2;
    return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

}
