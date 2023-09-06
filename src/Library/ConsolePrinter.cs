using System;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
            {
                Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
                foreach (Step step in recipe.steps)
                {
                    Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                        $"usando '{step.Equipment.Description}' durante {step.Time}");
                }
            }
    }
}
// Recipe tenia la responsabilidad de Agregar y remover los pasos de la receta (Armar la receta) y ademas de imprimirla. Si queremos seguir los patrones Grasp
// y Solid esto no es correcto. Son demasiadas responsabilidades para una sola clase. La solucion es agregar una nueva clase que tenga la unica responsabilidad
// de imprimir la rectea. Hacer esto trae muchos beneficios para mejorar la calidad del software al enfocarse en la asignación de responsabilidades y en la estructura de las clases y objetos.