using P5Ej7;

// Crear una instancia de Persona
Persona persona = new Persona();

// Establecer valores usando las propiedades
persona.Nombre = "Juan Pérez";
persona.Sexo = 'M';
persona.Dni = 12345678;
persona.FechaDeNacimiento = new DateTime(1990, 5, 15);

// Mostrar información
Console.WriteLine("Información de la persona:");
Console.WriteLine($"Nombre: {persona.Nombre}");
Console.WriteLine($"Sexo: {persona.Sexo}");
Console.WriteLine($"DNI: {persona.Dni}");
Console.WriteLine($"Fecha de Nacimiento: {persona.FechaDeNacimiento}");
Console.WriteLine($"Edad: {persona.Edad}");

// Cambiar algunos valores usando el indizador
persona[0] = "María García";
persona[1] = 'F';
persona[2] = 87654321;
persona[3] = new DateTime(1995, 3, 20);

// Mostrar la información actualizada
Console.WriteLine("\nInformación actualizada de la persona:");
Console.WriteLine($"Nombre: {persona[0]}");
Console.WriteLine($"Sexo: {persona[1]}");
Console.WriteLine($"DNI: {persona[2]}");
Console.WriteLine($"Fecha de Nacimiento: {persona[3]}");
Console.WriteLine($"Edad: {persona[4]}");