using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria___Desafio_3
{
    public class ContaBancaria
    {
        public Guid Id { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public DateTime CreatedAt { get; set; }

        public ContaBancaria(string numeroConta, double saldo)
        {
            Id = Guid.NewGuid();
            NumeroConta = numeroConta;
            Saldo = saldo;
            CreatedAt = DateTime.Now;
        }

        public void Depositar(double valorASerDepositado)
        {
            Saldo += valorASerDepositado;
        }
    }
}
