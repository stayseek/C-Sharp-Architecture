using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HW5_1
{
    class FigureFactory : IFigureFactory
    {
        Dictionary<string, Type> figureTypes;
        static Dictionary<string, IDrawAPI> drawableFigures = new Dictionary<string, IDrawAPI>();

        public FigureFactory()
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            figureTypes = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IDrawAPI).ToString()) != null)
                {
                    figureTypes.Add(type.Name, type);
                }
            }
        }

        private Type GetTypeToCreate(string figureType)
        {
            foreach (var figure in figureTypes)
            {
                if (figure.Key.Contains(figureType))
                {
                    return figureTypes[figure.Key];
                }
            }
            return null;
        }

        private IDrawAPI CreateInstance(string description)
        {
            Type t = GetTypeToCreate(description);
            if (t == null)
            {
                return new UnknownFigure();
            }
            return Activator.CreateInstance(t) as IDrawAPI;
        }

        public IDrawAPI GetFigure(string description)
        {
            if (!drawableFigures.ContainsKey(description))
            {
                drawableFigures.Add(description, CreateInstance(description));
            }
            return drawableFigures[description];
        }
    }
}
