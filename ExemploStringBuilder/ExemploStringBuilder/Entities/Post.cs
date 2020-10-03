using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public int  Likes { get; set; }

        //Nunca colocar listas em construtores 
        public List<Coment> Coments { get; set; } = new List<Coment>(); // inicializando list para ser diferente de Null

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int like)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = like;
        }

        public void  AddComent(Coment coment) {
            Coments.Add(coment);
        }
        public void RemoveComent(Coment coment) {
            Coments.Add(coment);
        }

        public override string ToString()
        {
            // carregar muitas strings em um toString nao seria uma boa opcao, mais custoso para o sistema 
            // se faz essencial neste caso utilizar um string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("******Coments:******");
            foreach(Coment coment in Coments) {
                sb.AppendLine(coment.Text);

            }

            return sb.ToString();
        }

    }
}
