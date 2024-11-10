using Taller.Interfaces;
using Taller.Models;

namespace Taller.Services
{
    public class CochesService : ICoches
    {
        public List<CocheModel> getCoches()
        {
            return new List<CocheModel>()
            {
                new CocheModel()
                {
                    Modelo = "RX-7",
                    Matricula = "1992 RXG",
                    Marca = "Mazda",
                    Year = 1992,
                    ImagenCoche = "/Imagenes/rx7.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Jared",
                        Apellido = "Bueno",
                        Dni = "Y4711918Z",
                        Correo = "uiopq600@gmail.com",
                        Telefono = "663663663",
                        Dir = new DireccionModel()
                        {
                            Calle = "Almansa",
                            Numero = "10",
                            Zip = "28039",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                new CocheModel()
                {
                    Modelo = "Civic Type R",
                    Matricula = "2018 FGH",
                    Marca = "Honda",
                    Year = 2018,
                    ImagenCoche = "/Imagenes/civicR.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Laura",
                        Apellido = "Gomez",
                        Dni = "33748290Y",
                        Correo = "laura.gomez@gmail.com",
                        Telefono = "612345678",
                        Dir = new DireccionModel()
                        {
                            Calle = "Avenida de la Paz",
                            Numero = "45",
                            Zip = "28021",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                new CocheModel()
                {
                    Modelo = "Mustang GT",
                    Matricula = "2020 ZXY",
                    Marca = "Ford",
                    Year = 2020,
                    ImagenCoche = "/Imagenes/mustangGT.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Carlos",
                        Apellido = "Martinez",
                        Dni = "36583924B",
                        Correo = "carlos.martinez@hotmail.com",
                        Telefono = "600987654",
                        Dir = new DireccionModel()
                        {
                            Calle = "Calle del Sol",
                            Numero = "22",
                            Zip = "28013",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                new CocheModel()
                {
                    Modelo = "Golf GTI",
                    Matricula = "2015 ADB",
                    Marca = "Volkswagen",
                    Year = 2015,
                    ImagenCoche = "/Imagenes/golfGTI.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Marta",
                        Apellido = "Rodriguez",
                        Dni = "31234567C",
                        Correo = "marta.rodri@gmail.com",
                        Telefono = "693456789",
                        Dir = new DireccionModel()
                        {
                            Calle = "Calle de la Libertad",
                            Numero = "55",
                            Zip = "28016",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                //Para probar estilos
                new CocheModel()
                {
                    Modelo = "RX-7",
                    Matricula = "1992 RXG",
                    Marca = "Mazda",
                    Year = 1992,
                    ImagenCoche = "/Imagenes/rx7.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Jared",
                        Apellido = "Bueno",
                        Dni = "Y4711918Z",
                        Correo = "uiopq600@gmail.com",
                        Telefono = "663663663",
                        Dir = new DireccionModel()
                        {
                            Calle = "Almansa",
                            Numero = "10",
                            Zip = "28039",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                new CocheModel()
                {
                    Modelo = "Civic Type R",
                    Matricula = "2018 FGH",
                    Marca = "Honda",
                    Year = 2018,
                    ImagenCoche = "/Imagenes/civicR.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Laura",
                        Apellido = "Gomez",
                        Dni = "33748290Y",
                        Correo = "laura.gomez@gmail.com",
                        Telefono = "612345678",
                        Dir = new DireccionModel()
                        {
                            Calle = "Avenida de la Paz",
                            Numero = "45",
                            Zip = "28021",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                new CocheModel()
                {
                    Modelo = "Mustang GT",
                    Matricula = "2020 ZXY",
                    Marca = "Ford",
                    Year = 2020,
                    ImagenCoche = "/Imagenes/mustangGT.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Carlos",
                        Apellido = "Martinez",
                        Dni = "36583924B",
                        Correo = "carlos.martinez@hotmail.com",
                        Telefono = "600987654",
                        Dir = new DireccionModel()
                        {
                            Calle = "Calle del Sol",
                            Numero = "22",
                            Zip = "28013",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                new CocheModel()
                {
                    Modelo = "Golf GTI",
                    Matricula = "2015 ADB",
                    Marca = "Volkswagen",
                    Year = 2015,
                    ImagenCoche = "/Imagenes/golfGTI.jpg",
                    Dueno = new OwnerModel()
                    {
                        Nombre = "Marta",
                        Apellido = "Rodriguez",
                        Dni = "31234567C",
                        Correo = "marta.rodri@gmail.com",
                        Telefono = "693456789",
                        Dir = new DireccionModel()
                        {
                            Calle = "Calle de la Libertad",
                            Numero = "55",
                            Zip = "28016",
                            Provincia = "Madrid",
                            Poblacion = "Madrid"
                        }
                    }
                },
                //Fin
            };
        }
    }
}
