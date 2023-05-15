
public abstract class Profesion
{
    protected string nombre;
    protected string area;
    public Profesion(string nombre, string area)
    {
        this.nombre = nombre;
        this.area = area;
    }

    public abstract string Descripcion();
}