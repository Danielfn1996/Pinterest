List<Persona> personas = new List<Persona>();
personas.Add(“79658321”, “Pedro Estiven”, “Gil Barón”, DateTime(1979, 10, 26));
personas.Add(“41582329”, “Ana María”, “López Torres”, DateTime(1954, 8, 12)); personas.Add(“84632206”, “Eugenio”, “Joya Rivera”, DateTime(1984, 5, 17)); personas.Add(“7456977”, “Carol Johanna”, “Pérez Castro”, DateTime(1975, 2, 5));
personas.Add(“15608542”, “Pablo Raúl”, “Téllez Sánchez”, DateTime(1949, 1, 19));
string result = ProcesarPersona(personas);



public string ProcesarPersona (List<Persona> personas)
{
decimal Resultado1 = 0; decimal Resultado2 = 0; int valor = 0;
DateTime fechaActual = new DateTime(2018, 3, 23);
foreach (Persona p in personas) {
valor = calcularEdad(p.FechaNacimiento, fechaActual);
if(valor>Resultado1){Resultado1=valor;} Resultado2 = Resultado2 + valor;
}
Resultado2 = Resultado2/personas.Length;
return “Resultado 1:” + Resultado1 + “Resultado 2:” + Resultado2;
}