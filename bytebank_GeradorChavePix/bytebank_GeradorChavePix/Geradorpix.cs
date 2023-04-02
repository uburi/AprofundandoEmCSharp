using System;
using System.Collections.Generic;

namespace bytebank_GeradorChavePix
{
    /// <summary>
    /// Classe que gera chaves Pix usando o formato Guid.
    /// </summary>
    public static class Geradorpix
    {
        /// <summary>
        /// Método que retorna uma chave aleatória Pix
        /// </summary>
        /// <returns>Retorna uma chave Pix no formato string</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// Método que retorna uma lista aleatória de chaves pix
        /// </summary>
        /// <param name="numeroChaves">Quantidade de chaves a serem geradas</param>
        /// <returns>Lista de strings de chaves Pix</returns>
        public static List<string> GetChavesPix(int numeroChaves)
        {
            if (numeroChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
