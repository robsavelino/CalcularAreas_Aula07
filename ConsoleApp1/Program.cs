using CalculaAreas;

Console.WriteLine("Este programa calcula as áreas de diversas formas geométricas");


Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Calculando a área do Quadrado");
Quadrado quadrado = new Quadrado();
quadrado.Lado = 5;
Console.WriteLine();
quadrado.Area();


Console.WriteLine();
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Calculando a área do Retângulo");
Retangulo retangulo = new Retangulo();
retangulo.Base = 5;
retangulo.Altura = 3;
retangulo.Area();

Console.WriteLine();
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Calculando a área do Triângulo");
Triangulo triangulo = new Triangulo();
triangulo.Base = 4;
triangulo.Altura = 3;
triangulo.Area();

Console.WriteLine();
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Calculando a área do Circulo");
Circulo circulo = new Circulo();
circulo.Raio = 10;
circulo.Area();

Console.ReadKey();




