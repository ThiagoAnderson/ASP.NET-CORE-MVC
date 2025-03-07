﻿
namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string  Email { get; set; }
        public DateTime  DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
            
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void adicionarVendas(RegistroVendas rv)
        {
            Vendas.Add(rv);
        }
        public void removerrVendas(RegistroVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double totalVendas(DateTime inicio, DateTime final) 
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(rv => rv.Quantia);
        }
    }
}
