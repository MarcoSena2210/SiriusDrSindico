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
            var objEndereco = new VEndereco(" Setor H, caminho 6", "1A", " 21", "Mussurubga-I", "BA", "Salvador", "4149080");

            var objCondominio = new Condominio(objEmpresa,"Estrela D'alva" ,  objEmail, objEndereco);
            var objEdificacao = new Edificacao(objCondominio,"Ed. Planeta star", objEndereco);
            var objImovel = new Imovel(objEdificacao, "1AP1001", "AP", "1AP1001");
            var objImovel1 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1002");
            var objImovel2 = new Imovel(objEdificacao, "1AP1001", "AP", "1AP1003");
            var objImovel3 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1004");
            var objImovel4 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1005");
            var objImovel5 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1006");
            var objImovel6 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1007");
            var objImovel7 = new Imovel(objEdificacao, "1AP1001", "AP", "1AP1008");
            var objImovel8 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1009");
            var objImovel9 = new Imovel(objEdificacao, "1AP1001","AP", "1AP1010");



            //var objMensalidade = new Mensalidade(); 

        }
    }
}
