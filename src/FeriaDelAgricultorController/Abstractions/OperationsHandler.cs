using FeriaDelAgricultorController.Abstractions;

namespace FeriaDelAgricultorController
{
    /// <summary>
    /// Implementación de <see cref="IOperationsHandler"/>.
    /// </summary>
    public class OperationsHandler : IOperationsHandler
    {
        /// <inheritdoc />
        public int ExecuteOperation(int input1, int input2, Operations operation)
        {
            if (operation == Operations.Add)
            {
                return Add(input1, input2);
            }

            // Por ahora solo hay suma. Luego podemos extenderlo.
            return 0;
        }

        /// <summary>
        /// Suma dos valores.
        /// </summary>
        private static int Add(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
