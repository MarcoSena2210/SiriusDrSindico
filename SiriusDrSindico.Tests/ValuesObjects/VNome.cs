using Microsoft.VisualStudio.TestTools.UnitTesting;
using SiriusDrSindico.Domain.ContextGeral.ValueObjects;

namespace SiriusDrSindico.Tests.ValuesObjects
{
    [TestClass]
    public class VNomeTests
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsNotValid()
        {
            var nome = new VNome("", "Sena");
            Assert.AreEqual(false, nome.IsValid);
            Assert.AreEqual(1, nome.Notifications.Count);
        }
    }
}
