using TPDecorator2;

AlumnoComponet al = new Alumno("Alfredo",1,1,8);
al.SetEstartegiaDeComparacion(new StrategyDeComparacionNombre());
al = new LegajoDecorator(al);
Console.WriteLine(al.MostrarCalificación());

AlumnoComponet al2 = new Alumno("Micaela", 2, 2, 9);
al2.SetEstartegiaDeComparacion(new StrategyDeComparacionNombre());

al2 = new LegajoDecorator(al2);

Console.WriteLine(al2.MostrarCalificación());

// aca funciona el strategy
Console.WriteLine(al.SosMayor(al2));