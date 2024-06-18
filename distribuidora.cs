namespace Distribuidora;

public class Tarea
{
    private int TareaID{get; set;}

    private string Descripcion{get; set;}

    private int Duracion{get; set;}

    public Tarea(int id, string descripcion, int duracion)
    {
        TareaID = id;
        Descripcion = descripcion;
        Duracion = duracion;
    }
    public int ObtenerTareaID()
    {
        return TareaID;
    }

    public string ObtenerDescripcion()
    {
        return Descripcion;
    }

    public int ObtenerDuracion()
    {
        return Duracion;
    }


}

public class GestorTareas
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasRealizadas = new List<Tarea>();

        public void crearAleatorio(int N)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                Tarea agregarTarea = new Tarea(i + 1, "Tarea ID: " + i, random.Next(1, 101));
                tareasPendientes.Add(agregarTarea);
            }
        }

        public void moverListaRealizadas(int id)
        {
            Tarea tareaAMover = null;
            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                if (tareasPendientes[i].ObtenerTareaID() == id)
                {
                    tareaAMover = tareasPendientes[i];
                    tareasPendientes.RemoveAt(i);
                    break;
                }
            }

            if (tareaAMover != null)
            {
                tareasRealizadas.Add(tareaAMover);
                Console.WriteLine("Tarea movida con éxito");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada");
            }
        }

        public void MostrarTareasPendientes()
        {
            Console.WriteLine("Tareas Pendientes:");
            foreach (Tarea tarea in tareasPendientes)
            {
                Console.WriteLine($"ID: {tarea.ObtenerTareaID()}, Descripción: {tarea.ObtenerDescripcion()}, Duración: {tarea.ObtenerDuracion()}");
            }
        }

        public void MostrarTareasRealizadas()
        {
            Console.WriteLine("Tareas Realizadas:");
            foreach (Tarea tarea in tareasRealizadas)
            {
                Console.WriteLine($"ID: {tarea.ObtenerTareaID()}, Descripción: {tarea.ObtenerDescripcion()}, Duración: {tarea.ObtenerDuracion()}");
            }
        }
    }
    