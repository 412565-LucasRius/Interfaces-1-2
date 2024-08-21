namespace Pilas_y_Colas.Interfaces
  {
  public interface ICollection
    {
    bool EstaVacia();

    Object Extraer();

    Object Primero();

    bool Añadir(Object obj);
    }
  }
