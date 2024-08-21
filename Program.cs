using Pilas_y_Colas.Domain;

Pila pila = new Pila(5);

pila.Añadir(1);
pila.Añadir(2);
pila.Añadir(3);
pila.Añadir(4);
pila.Añadir(5);

Console.WriteLine(pila.Primero());

object firstStack = pila.Primero();
Console.WriteLine(firstStack);

object extractedStack = pila.Extraer();
Console.WriteLine(extractedStack);


Cola cola = new Cola();

cola.Añadir(10);
cola.Añadir(15);
cola.Añadir(20);
cola.Añadir(25);
cola.Añadir(30);

object first = cola.Primero();
Console.WriteLine(first);

object extracted = cola.Extraer();

Console.WriteLine(extracted);

