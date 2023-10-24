﻿using Modelo;
using Modelo.Exceptions;
using Negocio;
using PRESENTACION;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

public class AltaCliente
{
    private static ValidacionesDatos vd = new ValidacionesDatos();
    private static ClientesNegocio pn = new ClientesNegocio();
    public static List<Clientes> clientes = new List<Clientes>();

    public void DarAltaCliente()
	{
        string inputNombre;
        string inputApellido;
        string inputDireccion;
        bool flag;
        string inputEmail;
        string inputDNI;
        int dni = 0;
        string inputTelefono;
        string inputFechaNacimiento;
        DateTime fechaNacimiento = DateTime.Now;
        string inputHost;
        Guid IdUsuario = Guid.Empty;
        string inputIdUsuario;

        do
        {
            Console.Write("Ingrese el nombre del cliente: ");
            inputNombre = Console.ReadLine();
            flag = vd.ValidarVacio(inputNombre, "Nombre");

        } while (flag == false);

        do
        {
            Console.Write("Ingrese el apellido del cliente: ");
            inputApellido = Console.ReadLine();
            flag = vd.ValidarVacio(inputApellido, "Apellido");

        } while (flag == false);

        do
        {
            Console.Write("Ingresar la dirección del cliente: ");
            inputDireccion = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputDireccion, "Dirección");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar un teléfono del cliente: ");
            inputTelefono = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputTelefono, "Telefono");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar un mail del cliente: ");
            inputEmail = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputEmail, "Email");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar la fecha de nacimiento del cliente: ");
            inputFechaNacimiento = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarFecha(inputFechaNacimiento, ref fechaNacimiento, "Fecha de Nacimiento");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar el dni del cliente: ");
            inputDNI = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarNumero(inputDNI, ref dni, "DNI");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar el grupo del cliente: ")
            inputHost = Console.Readline();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputEmail, "Email");
        } while (flag == false);

        do
        {
            flag = false;
            Console.Write("Ingrese el DNI del usuario como Id: ");
            inputIdUsuario = Console.ReadLine();
            Menu menu = new Menu();
            flag2 = false;

            if (menu.BuscarUsuarioID(inputIdUsuario) is null)
            {
                Console.WriteLine("El Id del Usuario introducido no es válido");
            }
            else if (menu.BuscarUsuarioID(inputIdUsuario) is not null)
            {
                Guid.TryParse(inputIdUsuario, out idUsuario);
                flag = true;
                flag2 = true;
            }

        } while (flag == false);

        Clientes cliente = new Clientes();
        cliente.IdCliente = new Guid();
        cliente.Nombre = inputNombre;
        cliente.Apellido = inputApellido;
        cliente.Direccion = inputDireccion;
        cliente.Telefono = inputTelefono;
        cliente.Email = inputEmail;
        cliente.Host = inputHost; 
        cliente.FechaNacimiento = Convert.ToDateTime(inputFechaNacimiento);
        cliente.DNI = Convert.ToInt32(inputDNI);
        cliente.FechaAlta = DateTime.Now;
        cliente.IdUsuario = IdUsuario;
    }
}