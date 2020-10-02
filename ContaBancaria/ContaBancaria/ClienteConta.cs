using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class ClienteConta
    {
        //Atributes
        private double _saldo = 0.0;
        private String _nome_cliente;
        private int _numero_conta;
        public double _deposito_inicial;



        //Constructors
        public ClienteConta() {

        }


        //
        public ClienteConta(string nome, int conta) {

            this._nome_cliente = nome;
            this._numero_conta = conta;

        }

        //Properties
        public string Nome {
            get { return _nome_cliente; }
            set {
                if (value.Length > 2) {
                    _nome_cliente = value;
                }
            }
        }
        public int NumeroConta {
            get { return _numero_conta; }
            set {
                if (value > 0) {
                    _numero_conta = value;
                }
            }
        }

        public double DepositoInicial {
            set {
                if (value > 0) {

                    _deposito_inicial = value;
                    Depositar(_deposito_inicial);
                }
            }
        }



        //Methods 

        public void Depositar(double valor) {
            if (valor > 0)
            {
                _saldo += valor;
            }
            else {
                Console.WriteLine("Operacao Invalida, tente novamente!");
            }
        }

        public void Sacar(int numero_conta, double valor) {
            if (this._numero_conta == numero_conta && valor <= _saldo)
            {
                _saldo = _saldo - valor;
            }
            else {
                Console.WriteLine("Saldo Insuficiente ou numero de conta incorreto!");
            }
        }

        public override string ToString()
        {
            return "Nome do cliente :" + _nome_cliente + " , numerio da conta : " + _numero_conta +" , Saldo : " + _saldo ;
        }


    }
}
