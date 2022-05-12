using System;
using System.Collections.Generic;

namespace CryptoMJ.Methods
{
    public class ListBase64Factory
    {
        public const string CharacteresBase64 = "E2oy5sxb1agn+TMqi4Lplc8tB76YmGRWFwDzjZrXK9AhQd=UJ/CI3VNOuHfP0evSk";
        private readonly int _lenght;
        private readonly int _jump;

        /// <summary>
        /// Fabrica para a lista de base64 utilizada para codificacao
        /// </summary>
        /// <param name="lenght">Tamanho da lista</param>
        /// <param name="jump">Pulo para embaralhar a string da lista</param>
        /// <exception cref="ArgumentException"></exception>
        public ListBase64Factory(int lenght, int jump)
        {
            if (lenght <= 0)
            {
                throw new ArgumentException("lenght to ListBase64Factory is invalid");
            }
            if (jump <= 0 || jump >= CharacteresBase64.Length)
            {
                throw new ArgumentException("jump to ListBase64Factory is invalid");
            }

            _lenght = lenght;
            _jump = jump;
        }

        public List<string> Create()
        {
            List<string> list = new List<string>();
            int index1 = 0;
            for (int i = 0; i < _lenght; i++)
            {
                string chars = CharacteresBase64;
                string newString = "";
                int index2 = GetIndex(index1++, CharacteresBase64);
                while (newString.Length < CharacteresBase64.Length)
                {
                    index2 = GetIndex(index2, chars);
                    char c = chars[index2];
                    newString += c;
                    chars = chars.Replace(c.ToString(), string.Empty);
                    index2 += _jump;
                }
                list.Add(newString);
            }

            return list;
        }

        private int GetIndex(int i, string chars)
        {
            return i > chars.Length - 1 ? 0 : i;
        }
    }
}
