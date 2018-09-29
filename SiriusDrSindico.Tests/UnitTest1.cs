using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SiriusDrSindico.Domain.ContextGeral.Entities;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {   
            /*Empresa*/                            
            var objNome = new VNome("Marco", "Sena"); 
            var objEend = new VEndereco("Rua J. Seabra","15a","Terreo","Centro","BA","Salvador","4148000");
            var objEmail = new VEmail("msena2210@gmail.com");
            var objEmpresa = new Empresa(objNome,"Sirius S/A","124589", objEmail,objEend); 
            Console.Write("Minha empresa" + objEmpresa.ToString());

        }
    }
}
