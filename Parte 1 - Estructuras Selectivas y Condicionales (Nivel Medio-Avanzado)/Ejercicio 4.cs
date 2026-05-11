Console.WriteLine("Inserte la puntuación de aire de su hogar");
string respuesta = Console.ReadLine().Trim();


string analisis = respuesta switch
{
"1" => "Aire deplorable. Mejor vendé la casa :)",
"2" => "Aire dañino. Se recomienda una profunda limpieza.",
"3" => "Aire malo. Se recomienda un purificador de aire",
"4" => "Aire moderado. Ya no sé que recomendación inventarme",
"5" => "Aire bueno. No hay recomendaciones",
_ => "Puntuación inválida. Intente de nuevo."
};


Console.WriteLine(analisis);
