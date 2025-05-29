using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabloMExamplesLayaous.Repositorios
{
    internal class ManejoArchivosRepository
    {
        //Crea un archivo de texto y guarda el contenido en él
        string path = Path.Combine(FileSystem.AppDataDirectory, "/notes.txt");
        public async Task<bool> GuardarArchivo(string texto)
        {
            try
            {
                //string path = Path.Combine(FileSystem.AppDataDirectory, "/notes.txt");
                await File.WriteAllTextAsync(path, texto);

                if (File.Exists(path))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Leer el contenido del archivo de texto
        public async Task<string> ObtenerInfromacionArchivo()
        {
            if (File.Exists(path))
            {
                string texto = await File.ReadAllTextAsync(path);
                return texto;
            }
            return "No encontre nada señor no me pege porfavor";

        }
    }
}
