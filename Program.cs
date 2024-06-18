using Distribuidora;
GestorTareas gestor = new GestorTareas();
gestor.crearAleatorio(10);

gestor.moverListaRealizadas(1);

gestor.MostrarTareasPendientes();
gestor.MostrarTareasRealizadas();
