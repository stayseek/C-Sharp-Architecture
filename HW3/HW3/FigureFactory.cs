using System;
using System.Collections.Generic;
using System.Reflection;

namespace HW3
{
    class FigureFactory
    {
        Dictionary<string, Type> figures;

        public FigureFactory()
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            figures = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IFigure).ToString()) != null)
                {
                    figures.Add(type.Name, type);
                }
            }
        }

        private Type GetTypeToCreate (string figureType)
        {
            foreach (var figure in figures)
            {
                if (figure.Key.Contains(figureType))
                {
                    return figures[figure.Key];
                }
            }
            return null;
        }

        public IFigure CreateInstance (string description, string width, string length)
        {
            Type t = GetTypeToCreate(description);
            if (t == null)
            {
                return new UnknownFigure();
            }
            return Activator.CreateInstance(t, width, length) as IFigure;
        }
    }
}
