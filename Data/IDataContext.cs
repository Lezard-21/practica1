namespace practica1;

public interface IDataContext{
    public Task<List<Producto>> ObtenerProductosAsync();
}