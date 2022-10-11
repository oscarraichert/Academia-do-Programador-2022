using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ClubeDaLeitura2._0
{
    public class Controlador<T>
    {
        public List<T> Lista;

        public Controlador()
        {
            Lista = Carregar();
        }

        public void Inserir(T entidade)
        {
            Lista.Add(entidade);
        }

        public void Editar(int indice, T entidade)
        {
            Lista[indice] = entidade;
        }

        internal void Exluir(int indice)
        {
            Lista.RemoveAt(indice);
        }

        internal List<T> Carregar()
        {
            if (!File.Exists($"..//..//..//SaveState{typeof(T).Name}.xml"))
            {
                return new List<T>();
            }

            XmlSerializer reader = new(typeof(List<T>));
            StreamReader file = new($"..//..//..//SaveState{typeof(T).Name}.xml");
            List<T> lista = (List<T>)reader.Deserialize(file);
            file.Close();

            return lista;
        }

        internal void Salvar()
        {
            XmlSerializer writer = new(typeof(List<T>));
            var path = $"..//..//..//SaveState{typeof(T).Name}.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, Lista);
            file.Close();
        }
    }
}