﻿using System.Text;
using DSAAlgorythm.Helpers;
using static DSAAlgorythm.Helpers.TextUtility;

namespace DSAAlgorythm.Data
{
    public class TextDataProvider: IDataProvider
    {
        public string Message { get; }
        public TextUtility.Encoding Encoding { get; }
        public TextDataProvider(string message, TextUtility.Encoding encoding)
        {
            Message = message;
            Encoding = encoding;
        }
        public byte[] GetData()
        {
            return Message.ToByteArray(Encoding);
        }

        public string GetStringData()
        {
            throw new System.NotImplementedException();
        }
    }
}
