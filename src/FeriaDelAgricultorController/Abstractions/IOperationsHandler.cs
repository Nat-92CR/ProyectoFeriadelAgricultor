namespace FeriaDelAgricultorController.Abstractions
{
    /// <summary>
    /// Interfaz para el manejo de operaciones de cálculo.
    /// Se puede reutilizar para sumas de ventas, cantidades, etc.
    /// </summary>
    public interface IOperationsHandler
    {
        /// <summary>
        /// Ejecuta la operación indicada.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <param name="operation">The operation.</param>
        /// <returns>The result of the operation provided.</returns>
        int ExecuteOperation(int input1, int input2, Operations operation);
    }
}
