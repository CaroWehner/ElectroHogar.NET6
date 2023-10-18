﻿using System;

public class Clientes
{
	public string _idcliente { get; set; }
	public string _nombre { get; set; }
	public string _apellido { get; set; }
	public string _direccion { get; set; }
	public string _telefono { get; set; }
	public string _email { get; set; }
	public string _idusuario { get; set; }
	public int _dni { get; set; }
	public datetime _fechaAlta { get; set; }
	public datetime _fechaBaja { get; set; }
	public datetime _fechaNacimiento { get; set; }
	public string _host { get; set; }

	public string IdCliente { get => _idcliente; set => _idcliente = value; }
	public string Nombre { get => _nombre; set => _nombre = value; }
	public string Apellido { get => _apellido; set => _apellido = value; }
    public string Direccion { get => _direccion; set => _direccion = value; }
    public string Telefono { get => _telefono; set => _telefono = value; }
    public string Email { get => _email; set => _email = value; }
	public string Host { get => _host; set => _host = value; }
	public datetime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
	public datetime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
	public datetime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

}