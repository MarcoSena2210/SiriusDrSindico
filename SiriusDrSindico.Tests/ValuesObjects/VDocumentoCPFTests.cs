using Microsoft.VisualStudio.TestTools.UnitTesting;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Tests.ValuesObjects
{
   
    [TestClass]
    public class VDocumentoCPFTests
    {
        private VDocumentoCPF validaDocumento;
        private VDocumentoCPF invalidoDocumentoCPF;

        public VDocumentoCPFTests()
        {
            validaDocumento = new VDocumentoCPF("28659170377");
            invalidoDocumentoCPF = new VDocumentoCPF("12345678910");
        }

        [TestMethod]
        public void DevolveNotificacaoQuandoDocumentoCpfNaoEhValido()
        {
            Assert.AreEqual(false, invalidoDocumentoCPF.IsValid);
            Assert.AreEqual(1, invalidoDocumentoCPF.Notifications.Count);
        }

        [TestMethod]
        public void  DevolveNotificacaoQuandoDocumentoCpfEhValido()
        {
            Assert.AreEqual(true, validaDocumento.IsValid);
            Assert.AreEqual(0, validaDocumento.Notifications.Count);
        }
    }
}