using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Security;

namespace Construtores
{
    class Produto
    {

            private string _nome;
            private double _preco;
            public int Quantidade { get; private set; }

            //Construtor
            public Produto() { 
                
            }
       
            public Produto(string nome, double preco, int quantidade ) {
                this._nome = nome;
                this._preco = preco;
                this.Quantidade = quantidade;
            }

            public Produto(string nome, double preco){
                this._nome = nome;
                this._preco = preco;
            }

            //Properties
            public string Nome {
                get { return _nome; }
                set {
                    if (value != null && value.Length > 1) {
                        _nome = value;
                    }
                    
                }
            }

            //LOGICAS personalizadas nao podem ser customizada pelas auto properties 
            public double Preco {
                get { return _preco;}
                set {
                    if (value != 0) {
                        _preco = value;
                    }
                }    
            }
            

            /*
            public string GetNome() {
                return this._nome;
            }
            public void SetNome(string nome) {
                if (nome != null && nome.Length >1) {
                    _nome = nome;
                }
            }

            public double GetPreco() {
                return this._preco; 
            }
            public void SetPreco(double preco) {
            _preco = preco;
            }   */


            //Metodos
            public double ValorTotalEmEstoque()
            {
                return _preco * Quantidade;
            }
            public void AdicionarProdutos(int quantidade)
            {
                Quantidade += quantidade;
            }
            public void RemoverProdutos(int quantidade)
            {
                Quantidade -= quantidade;
            }
            public override string ToString()
            {
                return _nome
                + ", $ "
                + _preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
            }
        
    }


}

