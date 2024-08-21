using Pilas_y_Colas.Interfaces;

namespace Pilas_y_Colas.Domain
  {
  public class Pila : ICollection
    {

    private Object[] Elementos { get; set; }

    private int Contador { get; set; }

    public Pila(int tamaño)
      {
      Elementos = new object[tamaño];
      Contador = 0;

      }

    public bool EstaVacia()
      {
      return Elementos.Length == 0;
      }

    public Object Extraer()
      {
      Object extraido = Elementos[-1];
      if (EstaVacia())
        {
        Console.WriteLine("El arreglo esta vacío");
        }

      for (int i = 0; i < Elementos.Length - 1; i++)
        {
        Elementos[i] = Elementos[i + 1];

        }
      Elementos[Elementos.Length - 1] = null;
      Contador--;

      //List<Object> listaElementos = new List<Object>(Elementos);
      //listaElementos.RemoveAt(0);

      return extraido;
      }

    public Object Primero()
      {
      return Elementos[0];
      }

    public bool Añadir(Object elemento)
      {
      bool añadido = false;

      Elementos[Contador] = elemento;

      if (Elementos[Contador] == elemento)
        {
        añadido = true;
        }

      Contador++;
      return añadido;
      }
    }
  }
