using Pilas_y_Colas.Interfaces;

namespace Pilas_y_Colas.Domain
  {
  public class Cola : ICollection
    {
    private List<Object> Elementos { get; set; }

    public Cola()
      {
      Elementos = new List<Object>();
      }

    public bool EstaVacia()
      {
      return Elementos.Count == 0;
      }

    public object Extraer()
      {
      object extraido = Elementos.Last();

      Elementos.RemoveAt(0);

      return extraido;
      }

    public object Primero()
      {
      return Elementos.First();
      }

    public bool Añadir(object elemento)
      {
      bool añadido = false;
      if (Elementos.Contains(elemento))
        {
        Console.WriteLine("El elemento ya existe");
        }
      else
        {
        Elementos.Add(elemento);
        añadido = true;

        }
      return añadido;
      }
    }
  }
