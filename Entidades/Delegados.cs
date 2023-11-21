/// <summary>
/// Delegado utilizado para mostrar un label.
/// </summary>
public delegate void delegadoMostrarLBL();

/// <summary>
/// Delegado utilizado para manejar eventos de fallo con excepciones.
/// </summary>
/// <param name="ex">Excepción</param>
public delegate void delegadoFalla(Exception ex);

/// <summary>
/// Delegado utilizado para manejar eventos relacionados con un cuadro de diálogo de guardado.
/// </summary>
/// <param name="sender">Objeto que desencadenó el evento.</param>
/// <param name="e">Argumentos del evento.</param>
public delegate void delegadoSaveDialog(object sender, EventArgs e);

/// <summary>
/// Delegado utilizado para manejar eventos de cambio de capacidad (en las internaciones de la veterinaria)
/// </summary>
/// <param name="capacidad">Nueva capacidad.</param>
public delegate void delegadoCambiarCapacidad(int capacidad);

/// <summary>
/// Delegado utilizado para mostrar mensajes.
/// </summary>
/// <param name="mensaje">Mensaje a mostrar.</param>
public delegate void delegadoMensaje(string mensaje);